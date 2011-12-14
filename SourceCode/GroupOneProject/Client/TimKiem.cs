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
    public partial class TimKiem : Form
    {
        private IService proxy = Proxy.New_Proxy_WSHttpBingding();
        private string MSSV = GlobalVariable.Username;
        public TimKiem()
        {
            InitializeComponent();
        }

        private void but_TimKiem_Click(object sender, EventArgs e)
        {
            string keycode;
            if (txt_keyword.Text == "" && txt_MaMH.Text =="")
            {
                MessageBox.Show("Nhập mã số MH hoặc từ khóa");
                txt_MaMH.Focus();
            }
            else
            {
                if (txt_MaMH.Text != "")
	            {
		            keycode = txt_MaMH.Text;
	            }
                else
                    keycode = txt_keyword.Text;

                try
                {
                    grid_listMonhoc.DataSource = proxy.Search_Subject(keycode);
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
        }

        private void grid_listMonhoc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                string MaMH = grid_listMonhoc.CurrentRow.Cells[1].Value.ToString();
                try
                {
                    grid_ketqua.DataSource = proxy.Mark_Subject_Single(MSSV, MaMH);
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
        }
    }
}
