using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.ServiceModel;
using Client.MarkManagementService;

namespace Client
{
    public partial class frmMain_Client : Form
    {
        private EndpointAddress address;
        private IService proxy;
        private Member[] lstMem;
        public frmMain_Client()
        {
            InitializeComponent();
        }
        private void btn_Author_BasHttp_Click(object sender, EventArgs e)
        {
            try
            {
                address = new EndpointAddress("http://localhost:"+txtLLocaBasHttp.Text+"/MarkManagementService");
                BasicHttpBinding binding = new BasicHttpBinding();
                proxy = ChannelFactory<IService>.CreateChannel(binding,address);
                
                lstMem = proxy.GetAuthors();
                grid_basHttp.DataSource = lstMem;
            }
            catch
            {
                MessageBox.Show("Service not responding!", "Warning", MessageBoxButtons.OK);
            }

        }
        private void btn_Author_WsHttp_Click(object sender, EventArgs e)
        {
            try
            {
                address = new EndpointAddress("http://localhost:"+txtLLocaWsHttp.Text+"/MarkManagementService");
                WSHttpBinding binding = new WSHttpBinding();

                proxy = ChannelFactory<IService>.CreateChannel(binding, address);
                lstMem = proxy.GetAuthors();
                grid_WsHttp.DataSource = lstMem;
            }
            catch
            {
                MessageBox.Show("Service not responding!", "Warning", MessageBoxButtons.OK);
            }

        }
        private void btn_Author_WsDualHttp_Click(object sender, EventArgs e)
        {
            try
            {
                address = new EndpointAddress("http://localhost:" + txtLLocaWsDualHttp.Text + "/MarkManagementService");
                WSDualHttpBinding binding = new WSDualHttpBinding();

                proxy = ChannelFactory<IService>.CreateChannel(binding, address);
                lstMem = proxy.GetAuthors();
                grid_WsHttp.DataSource = lstMem;
            }
            catch
            {
                MessageBox.Show("Service not responding!", "Warning", MessageBoxButtons.OK);
            }

        }

        private void btn_Author_NetTcp_Click(object sender, EventArgs e)
        {
            try
            {
                address = new EndpointAddress("net.tcp://localhost:"+txtLLocaNetTcp.Text+"/MarkManagementService");
                
                NetTcpBinding binding = new NetTcpBinding();

                proxy = ChannelFactory<IService>.CreateChannel(binding, address);
                lstMem = proxy.GetAuthors();
                grid_netTcp.DataSource = lstMem;
            }
            catch
            {
                MessageBox.Show("Service not responding!", "Warning", MessageBoxButtons.OK);
            }

        }
        private void btn_Author_netNamePipe_Click(object sender, EventArgs e)
        {
            try
            {
                address = new EndpointAddress("net.pipe://localhost/MarkManagementService");

                NetNamedPipeBinding binding = new NetNamedPipeBinding();

                proxy = ChannelFactory<IService>.CreateChannel(binding, address);
                lstMem = proxy.GetAuthors();
                grid_netNPipe.DataSource = lstMem;
            }
            catch
            {
                MessageBox.Show("Service not responding!", "Warning", MessageBoxButtons.OK);
            }

        }
    }
}
