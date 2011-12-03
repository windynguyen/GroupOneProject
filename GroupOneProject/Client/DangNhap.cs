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
        private IService proxy = Proxy.New_Proxy_NetNamedPipeBinding();
        private int mode;
        private int mode_SV = 0;
        private int mode_PH = 1;
        private int mode_GV = 2;
        private bool result_login;

        private void but_Login_Click(object sender, EventArgs e)
        {
            try
            {
                if (rdo_sinhvien.Checked)
                {
                    mode = mode_SV;
                    result_login = proxy.CheckLogin(txt_username.Text, txt_pass.Text, mode_SV);
                }
                else if (rdo_phuhuynh.Checked)
                {
                    mode =mode_PH;
                    result_login = proxy.CheckLogin(txt_username.Text, txt_pass.Text, mode_PH);
                }
                else
                {
                    mode = mode_GV;
                    result_login = proxy.CheckLogin(txt_username.Text, txt_pass.Text, mode_GV);
                }
                if (result_login)
                {
                    this.Hide();
                    GlobalVariable.Username = txt_username.Text;
                    GlobalVariable.Mode = mode;
                    switch (mode)
                    {
                        case 0:
                            {
                                SV_Main frmMain = new SV_Main();
                                frmMain.Show();
                                break;
                            }
                        case 1:
                            {
                                SV_Main frmMain = new SV_Main();
                                frmMain.Show();
                                break;
                            }
                        case 2:
                            {
                                GV_Main frmMain = new GV_Main();
                                frmMain.Show();
                                break;
                            }

                    }
                    
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
