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
    public partial class GV_DanhSachLopMH : Form
    {
        private string code_lecturer, code_subject, name_subject, semester;
        public GV_DanhSachLopMH(string _code_lecturer, string _code_subject, string _name_subject, string _semester)
        {
            code_lecturer = _code_lecturer;
            code_subject = _code_subject;
            name_subject = _name_subject;
            semester = _semester;
            InitializeComponent();
        }
        private IService proxy = Proxy.New_Proxy_WSHttpBingding();
        private List_Stu_Class[] lst;
        private Statistic_Mark Sta;
        private void GV_DanhSachLopMH_Load(object sender, EventArgs e)
        {
            Load_DanhSach();
            Load_ThongKe();
        }
        public void Load_DanhSach()
        {
            try
            {
                lbl_maMH.Text = code_subject;
                lbl_tenMH.Text = name_subject;
                lbl_hocky.Text = semester;
                lst = proxy.List_Class(code_lecturer, code_subject, semester);
                grid_danhsachlop.DataSource = lst;
            }
            catch (Exception)
            {
                MessageBox.Show("Service not response", "Error");
            }
        }
        public void Load_ThongKe()
        {
            try 
	        {	        
		        Sta = proxy.Statistic_Mark_General(code_lecturer, code_subject, semester);
                txt_siso.Text = Sta.Total.ToString();
                txt_duoi5.Text = Sta.Less_than_5.ToString();
                txt_5_8.Text = Sta.Distance_5_8.ToString();
                txt_8_10.Text = Sta.Distance_8_10.ToString();
                txt_max.Text = Sta.Max_mark.ToString();
                txt_min.Text = Sta.Min_mark.ToString();
                txt_avg.Text = Sta.Avg_mark.ToString();
	        }
	        catch (Exception)
	        {
                MessageBox.Show("Service not response", "Error");
	        }
        }
    }
}
