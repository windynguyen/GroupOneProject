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

namespace Client
{
    public partial class ThongTinCN : Form
    {
        public ThongTinCN()
        {
            InitializeComponent();
        }
        private IService proxy = Proxy.New_Proxy_WSHttpBingding(); private Student SV;
        private string MSSV = GlobalVariable.Username;
        private void ThongTinCN_Load(object sender, EventArgs e)
        {
            try
            {
                SV = proxy.Get_Info_Stu(MSSV);
                BinDataToControl(SV);
            }
            catch (Exception)
            {
                MessageBox.Show("Service not response", "Error");
            }
        }
        public void BinDataToControl(Student SV)
        {
            groupBox.Text = "MSSV: "+SV.Mssv;
            txt_hoten.Text = SV.Hoten;
            txt_ngaysinh.Text = SV.Ngaysinh;
            txt_noisinh.Text = SV.Noisinh;
            txt_lop.Text = SV.Lop;
            txt_nganh.Text = SV.Nganh;
            txt_khoa.Text = SV.Khoa;
            txt_heDT.Text = SV.HeDT;
            txt_khoa_hoc.Text = SV.Khoahoc;
            txt_diachi.Text = SV.Diachi;
            txt_dienthoai.Text = SV.Dienthoai;
            txt_email.Text = SV.Email;
            txt_quoctich.Text = SV.Quoctich;
            txt_tcDT.Text = SV.TongTC.ToString();
            txt_tongiao.Text = SV.Tongiao;
            txt_dantoc.Text = SV.Dantoc;
            txt_hotencha.Text = SV.Hotencha;
            txt_hotenme.Text = SV.Hotenme;
            txt_nghecha.Text = SV.Nghenghiepcha;
            txt_ngheme.Text = SV.Nghenghiepme;
            if (SV.Gioitinh == 0)
            {
                rdo_nam.Checked = true;
            }
            else
                rdo_nu.Checked = true;
        }
        public void BinControlToEntity(ref Student SV)
        {
            SV.Diachi = txt_diachi.Text;
            SV.Dienthoai = txt_dienthoai.Text;
            SV.Email = txt_email.Text;
            SV.Quoctich = txt_quoctich.Text;
            SV.Tongiao = txt_tongiao.Text;
            SV.Dantoc = txt_dantoc.Text;
            SV.Hotencha = txt_hotencha.Text;
            SV.Hotenme = txt_hotenme.Text;
            SV.Nghenghiepcha = txt_nghecha.Text;
            SV.Nghenghiepme = txt_ngheme.Text;
        }

        private void but_sua_Click(object sender, EventArgs e)
        {
            if (GlobalVariable.Mode == 0)
            {
                but_sua.Enabled = false;
                txt_diachi.Enabled = txt_dienthoai.Enabled = txt_diachi.Enabled =
                txt_email.Enabled = txt_tongiao.Enabled = txt_quoctich.Enabled =
                txt_dantoc.Enabled = txt_hotencha.Enabled = txt_hotenme.Enabled =
                txt_nghecha.Enabled = txt_ngheme.Enabled =
                but_submit.Enabled = but_huy.Enabled = true;
            }
            else
                MessageBox.Show("Phụ huynh không được phép sửa thông tin cá nhân sinh viên", "Thông báo");
        }

        private void but_huy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void but_submit_Click(object sender, EventArgs e)
        {
            BinControlToEntity(ref SV);
            try
            {
                bool isOk = proxy.Update_Info_Stu(SV);
                if (isOk)
                {
                    MessageBox.Show("Cập nhận thông tin thành công", "Thông báo");
                    but_sua.Enabled = true;
                    but_submit.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Cập nhận thông tin thất bại", "Thông báo");
                    Close();
                }
            }
            catch(FaultException<InfoFault[]> fe)
            {
                string mess, Mess = fe.Detail.Length + " FaultException" + "\n\n";
                foreach (InfoFault inf in fe.Detail)
                {
                    mess = inf.Message;
                    Mess += mess + "\n\n";
                }
                MessageBox.Show(Mess);
            }
            catch (FaultException x) //lỗi bất định
            {
                MessageBox.Show("An unknown exception was received. " + x.Message);
            }
            catch (CommunicationException commProblem) //lỗi giao tiếp với server
            {
                MessageBox.Show("There was a communication problem. " + commProblem.Message + commProblem.StackTrace);
            }

            
        }
    }
}
