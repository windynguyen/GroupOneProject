using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.ServiceModel;
using Client.GetMark_Service;
using System.Threading;

namespace Client
{
    public partial class SV_Main : Form
    {
        private IService proxy = Proxy.New_Proxy_WSHttpBingding(); 
        private string[] listHK;
        private Mark[] Array_kq;
        private Student_Semester Sv_hk;
        private string MSSV = GlobalVariable.Username;

        public SV_Main()
        {
            InitializeComponent();
            lbl_TCDK.Text = lbl_TCDAT.Text = lbl_TBHK.Text = "";
            
        }

        private void Main_Load(object sender, EventArgs e)
        {
            //Thread threadLoadlstHK = new Thread(Load_List_HK);
            //threadLoadlstHK.Start();
            Load_List_HK();
            llbl_mssv.Text = GlobalVariable.Username;
        }
        public void Load_List_HK()
        {
            try
            {
                listHK = proxy.List_Semester();
                foreach (string item in listHK)
                {
                    cbo_listHK.Items.Add(item);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Service not response", "Error");
            }
        }

        private void but_show_Click(object sender, EventArgs e)
        {
            string selectedHocKy = cbo_listHK.Text;
            if (selectedHocKy == "")
            {
                MessageBox.Show("Hãy chọn học kỳ cần xem kết quả","Thông báo");
                cbo_listHK.Focus();
            }
            else
            {
                try
                {
                    this.Array_kq = proxy.Get_Mark_Semester(MSSV, selectedHocKy);
                    this.Sv_hk = proxy.Info_Stu_Sem_Only(MSSV, selectedHocKy);
                    if (this.Sv_hk != null)
                    {
                        grid_KetQua.DataSource = this.Array_kq;
                        lbl_TCDK.Text = this.Sv_hk.TC_dk_HK.ToString();
                        lbl_TCDAT.Text = this.Sv_hk.TC_dat_HK.ToString();
                        lbl_TBHK.Text = this.Sv_hk.TBHK.ToString();
                    }
                    else
                    {
                        MessageBox.Show("Chưa có dữ liệu cho học kỳ " + selectedHocKy, "Thông báo");
                        grid_KetQua.DataSource = null;
                        lbl_TCDK.Text = lbl_TCDAT.Text = lbl_TBHK.Text = "";
                    }
                    
                }
                catch (Exception)
                {
                    MessageBox.Show("Service not response", "Error");
                }
                
            }
            
        }

        private void llbl_mssv_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ThongTinCN frmProfile = new ThongTinCN();
            frmProfile.Show();
        }

        private void llbl_logout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            GlobalVariable.Username = "";
            this.Hide();
            DangNhap frmDangNhap = new DangNhap();
            frmDangNhap.Show();
        }

        private void but_ThongKe_Click(object sender, EventArgs e)
        {
            SV_ThongKe frmThongke = new SV_ThongKe();
            frmThongke.Show();
        }

        private void lbl_changpass_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            gbb_pass.Visible = true;

        }

        private void but_ok_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_passold.Text == "" || txt_passnew.Text == "" || txt_confirmPass.Text == "")
                {
                    MessageBox.Show("Điền đầuy đủ thông tin");

                }
                else if (txt_passnew.Text != txt_confirmPass.Text)
                {
                    MessageBox.Show("Xác nhận mật khẩu không trùng khớp");
                }
                else
                {
                    bool result = proxy.ChangePassword(MSSV, txt_passold.Text, txt_passnew.Text, GlobalVariable.Mode);
                    if (result)
                    {
                        MessageBox.Show("Thay đổi mật khẩu thành công");
                    }
                    else
                        MessageBox.Show("Thay đổi mật khẩu không thành công");
                }
            }
            catch (FaultException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception)
            {
                MessageBox.Show("Service not response", "Error");
            }
            
        }

    }
}
