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
    public partial class PhanHoi : Form
    {
        public PhanHoi()
        {
            InitializeComponent();
        }
        private IService proxy = Proxy.New_Proxy_WSHttpBingding();
        private string MSSV = GlobalVariable.Username;
        private void but_gui_Click(object sender, EventArgs e)
        {
            try
            {
                proxy.Send_Feedback(MSSV, txt_TieuDe.Text, txt_NoiDung.Text);
                MessageBox.Show("Phản hồi đã được gửi đi","Thông báo");
            }
            catch (FaultException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (CommunicationException commProblem) //lỗi giao tiếp với server
            {
                MessageBox.Show("There was a communication problem. " + commProblem.Message + commProblem.StackTrace);
            }
        }

        private void but_huy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tabControl1_Selected(object sender, TabControlEventArgs e)
        {
            if (e.TabPage == tabControl1.TabPages[1])
            {
                try
                {
                    Feedback[] lstFeedback;
                    lstFeedback = proxy.Load_Feedback(MSSV);
                    grid_reply.DataSource = lstFeedback;
                }
                catch (Exception)
                {

                    throw;
                }
            } 
        }

        private void grid_reply_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                grb_mess.Text = grid_reply.CurrentRow.Cells[2].Value.ToString();
                txt_sub.Text = grid_reply.CurrentRow.Cells[3].Value.ToString();
                txt_content.Text = grid_reply.CurrentRow.Cells[1].Value.ToString();
                if (Convert.ToBoolean(grid_reply.CurrentRow.Cells[5].Value) == false)
                {
                    txt_reply.Text = "Chưa có trả lời";
                }
                else
                {
                    //lbl_reply.Text = "Trả lời: " + grid_reply.CurrentRow.Cells[4].Value.ToString();
                    txt_reply.Text = grid_reply.CurrentRow.Cells[4].Value.ToString();
                }
                /*MaMH = grib_All_Subject.CurrentRow.Cells[1].Value.ToString();
                TenMH = grib_All_Subject.CurrentRow.Cells[2].Value.ToString();
                Hocky = grib_All_Subject.CurrentRow.Cells[3].Value.ToString();
                try
                {
                    frmDS = new GV_DanhSachLopMH(MaGV, MaMH, TenMH, Hocky);
                    frmDS.Show();
                }
                catch (Exception)
                {
                    MessageBox.Show("Service not response", "Error");
                }*/
            }
        }


    }
}
