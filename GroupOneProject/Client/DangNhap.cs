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
    public partial class DangNhap : Form
    {
        public DangNhap()
        {
            InitializeComponent();
            txt_username.Focus();
        }
        private EndpointAddress address;
        private IService proxy;
        private int mode_SV = 0;
        private int mode_GD = 1;
        private bool result_login;

        private void but_Login_Click(object sender, EventArgs e)
        {
            address = new EndpointAddress("http://localhost:3000/GetMark_Service");
            WSHttpBinding binding = new WSHttpBinding();

            proxy = ChannelFactory<IService>.CreateChannel(binding, address);
            try
            {
                if (chb_mode.Checked)
                {
                    result_login = proxy.CheckLogin(txt_username.Text, txt_pass.Text, mode_GD);
                }
                else
                {
                    result_login = proxy.CheckLogin(txt_username.Text, txt_pass.Text, mode_SV);
                }
                if (result_login)
                {
                    //MessageBox.Show("Đăng nhập thành công","Thông báo");
                    this.Hide();
                    GlobalVariable.Mssv = txt_username.Text;
                    Main frmMain = new Main();
                    frmMain.Show();
                }
                else
                    MessageBox.Show("Đăng nhập thất bại", "Thông báo");
            }
            catch
            {
                MessageBox.Show("Service not responding!", "Warning", MessageBoxButtons.OK);
            }
        }
    }
}
