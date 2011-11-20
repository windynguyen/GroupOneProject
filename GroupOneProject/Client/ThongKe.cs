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
    public partial class ThongKe : Form
    {
        public ThongKe()
        {
            InitializeComponent();
        }
        private static EndpointAddress address = new EndpointAddress("http://localhost:3000/GetMark_Service");
        private static WSHttpBinding binding = new WSHttpBinding();
        private static IService proxy = ChannelFactory<IService>.CreateChannel(binding, address);
        Statistic infoStat = new Statistic();
        private void ThongKe_Load(object sender, EventArgs e)
        {
            try
            {
                infoStat = proxy.Info_Statistic(GlobalVariable.Mssv);
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
            }
            catch (Exception)
            {
                MessageBox.Show("Service not response", "Error");
            }
        }
    }
}
