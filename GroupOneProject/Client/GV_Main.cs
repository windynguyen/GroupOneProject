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
using System.IO;

namespace Client
{
    public partial class GV_Main : Form
    {
        public GV_Main()
        {
            InitializeComponent();
        }
        private IService proxy = Proxy.New_Proxy_WSHttpBingding(); 
        private string[] listHK;
        private string MaGV = GlobalVariable.Username;
        private string MaMH, TenMH, Hocky;
        private void GV_Main_Load(object sender, EventArgs e)
        {
            Load_List_HK();
            lnkUsername.Text = GlobalVariable.Username;
        }
        public void Load_List_HK()
        {
            try
            {
                listHK = proxy.List_Semester();
                cbo_hocky.Items.Add("Tất cả");
                foreach (string item in listHK)
                {
                    cbo_hocky.Items.Add(item);
                }
            }
            catch (CommunicationException commProblem) //lỗi giao tiếp với server
            {
                MessageBox.Show("There was a communication problem. " + commProblem.Message + commProblem.StackTrace);
            }
        }
        private void but_xem_Click(object sender, EventArgs e)
        {
            Subject[] lst_sub =new Subject[100];
            try
            {
                if (cbo_hocky.Text == "Tất cả")
                {
                    lst_sub = proxy.Lec_Sub_All(MaGV);
                }
                else if (cbo_hocky.Text == "")
                    MessageBox.Show("Vui lòng chọn 'học kì' cần xem!", "Lỗi chọn!");
                else
                    lst_sub = proxy.Lec_Sub_Single(MaGV, cbo_hocky.Text);
                grib_All_Subject.DataSource = lst_sub;
            }
            catch (CommunicationException commProblem) //lỗi giao tiếp với server
            {
                MessageBox.Show("There was a communication problem. " + commProblem.Message + commProblem.StackTrace);
            }
            
        }

        private void grib_All_Subject_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                GV_DanhSachLopMH frmDS;
                MaMH = grib_All_Subject.CurrentRow.Cells[1].Value.ToString();
                TenMH = grib_All_Subject.CurrentRow.Cells[2].Value.ToString();
                Hocky = grib_All_Subject.CurrentRow.Cells[3].Value.ToString();
                try
                {
                    frmDS = new GV_DanhSachLopMH(MaGV, MaMH, TenMH, Hocky);
                    frmDS.Show();
                }
                catch (CommunicationException commProblem) //lỗi giao tiếp với server
                {
                    MessageBox.Show("There was a communication problem. " + commProblem.Message + commProblem.StackTrace);
                }
            }
        }

        private void llbl_logout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            GlobalVariable.Username = "";
            this.Hide();
            DangNhap frmDangNhap = new DangNhap();
            frmDangNhap.Show();
        }

        private void lbl_changpass_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            gbb_pass.Visible = true;
        }

        private void but_phanhoi_Click(object sender, EventArgs e)
        {
            PhanHoi frm_PhanHoi = new PhanHoi();
            frm_PhanHoi.Show();
        }

       
    }
}
