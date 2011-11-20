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
    public partial class StudentInfo : Form
    {
        public StudentInfo()
        {
            InitializeComponent();
        }

        private EndpointAddress address;
        private IService proxy;

        private void btnGetSV_Click(object sender, EventArgs e)
        {
            address = new EndpointAddress("http://localhost:3000/GetMark_Service");
            WSHttpBinding binding = new WSHttpBinding();

            proxy = ChannelFactory<IService>.CreateChannel(binding, address);

            try
            {
                //dtGrid.DataSource = proxy.GetInfoSV_New("");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
