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
    public partial class Main : Form
    {
        private static EndpointAddress address = new EndpointAddress("http://localhost:3000/GetMark_Service");
        private static WSHttpBinding binding = new WSHttpBinding();
        private static IService proxy = ChannelFactory<IService>.CreateChannel(binding, address);
        private string[] listHK;
        private KetQua[] Array_kq;
        private SV_HK Sv_hk;
        private string MSSV = GlobalVariable.Mssv;
        public Main()
        {
            InitializeComponent();
            lbl_TCDK.Text = lbl_TCDAT.Text = lbl_TBHK.Text = "";
            
        }

        private void Main_Load(object sender, EventArgs e)
        {
            //Thread threadLoadlstHK = new Thread(Load_List_HK);
            //threadLoadlstHK.Start();
            Load_List_HK();
            llbl_mssv.Text = GlobalVariable.Mssv;
        }
        public void Load_List_HK()
        {
            try
            {
                listHK = proxy.List_HK();
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
                    this.Array_kq = proxy.KetQua_HK(MSSV, selectedHocKy);
                    this.Sv_hk = proxy.InfoSV_HK(MSSV, selectedHocKy);
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
            GlobalVariable.Mssv = "";
            this.Hide();
            DangNhap frmDangNhap = new DangNhap();
            frmDangNhap.Show();
        }

        private void but_ThongKe_Click(object sender, EventArgs e)
        {
            ThongKe frmThongke = new ThongKe();
            frmThongke.Show();
        }

    }
}
