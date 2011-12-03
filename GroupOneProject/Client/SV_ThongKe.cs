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
    public partial class SV_ThongKe : Form
    {
        public SV_ThongKe()
        {
            InitializeComponent();
        }
        private IService proxy = Proxy.New_Proxy_WSHttpBingding(); 
        Statistic_Student infoStat = new Statistic_Student();
        private void ThongKe_Load(object sender, EventArgs e)
        {
            try
            {
                infoStat = proxy.Info_Statistic_Stu_General(GlobalVariable.Username);
                lbl_TongMH.Text = infoStat.TongMH.ToString();
                lbl_TongMH_no.Text = infoStat.TongMH_no.ToString();
                lbl_TC_dk.Text = infoStat.TongTC_dk.ToString();
                lbl_TC_dat.Text = infoStat.TongTC_dat.ToString();
                lbl_TB_tichluy.Text = infoStat.TB_tichluy.ToString();

                lbl_xuatsac.Text = infoStat.Tong_xuatsac.ToString();
                lbl_gioi.Text = infoStat.Tong_gioi.ToString();
                lbl_kha.Text = infoStat.Tong_kha.ToString();
                lbl_trungbinh.Text = infoStat.Tong_trungbinh.ToString();
                lbl_kem.Text = infoStat.Tong_kem.ToString();
                DrawTCProgress(infoStat.TongTC_dk, infoStat.TongTC_dat);
                
            }
            catch (Exception)
            {
                MessageBox.Show("Service not response", "Error");
            }
        }
        private void DrawTCProgress(int tongTC, int datTC)
        {
            if (infoStat.TongTC_dk > 0)
            {
                int tcProgress = (datTC * lblBackGround1.Width) / tongTC;
                lblTinChiProgress.Visible = true;
                lblTinChiProgress.Width = tcProgress;
                lblTinChiProgress.Text = (datTC * 100 / tongTC).ToString() + "%";
            }
            else
            {
                lblTinChiProgress.Visible = false;
                lblBackGround1.Text = "0%";
            }
        }
    }
}
