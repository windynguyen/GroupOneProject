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
        private static EndpointAddress address = new EndpointAddress("http://localhost:3000/GetMark_Service");
        private static WSHttpBinding binding = new WSHttpBinding();
        private static IService proxy = ChannelFactory<IService>.CreateChannel(binding, address);
        private SinhVien SV;
        private string MSSV = GlobalVariable.Mssv;
        private void ThongTinCN_Load(object sender, EventArgs e)
        {
            try
            {
                SV = proxy.GetInfoSV(MSSV);
                BinDataToControl(SV);
            }
            catch (Exception)
            {
                MessageBox.Show("Service not response", "Error");
            }
        }
        public void BinDataToControl(SinhVien SV)
        {
            groupBox.Text = "MSSV: "+SV.Mssv;
            txt_nganh.Text = SV.Mssv;
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
        public void BinControlToEntity(ref SinhVien SV)
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
            but_sua.Enabled = false;
            txt_diachi.Enabled = txt_dienthoai.Enabled = txt_diachi.Enabled = 
            txt_email.Enabled = txt_tongiao.Enabled= txt_quoctich.Enabled =
            txt_dantoc.Enabled = txt_hotencha.Enabled = txt_hotenme.Enabled = 
            txt_nghecha.Enabled = txt_ngheme.Enabled = 
            but_submit.Enabled = but_huy.Enabled = true;
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
                bool isOk = proxy.UpdateInfoSV(SV);
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
            catch (Exception)
            {
                MessageBox.Show("Service not response", "Error");
            }

            
        }
    }
}
