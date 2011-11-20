using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.ServiceModel;
using ServiceLibrary;
using System.ServiceModel.Description;

namespace ServiceHost_Form
{
    public partial class frmMainHost : Form
    {
        public frmMainHost()
        {
            InitializeComponent();
        }
        //Tham khao: [http://www.codeproject.com/KB/WCF/HttpBinding.aspx]

        private ServiceHost MainHost;
        private BindingSource EndpointSource = new BindingSource();
        public void StartService()
        {
            try
            {
                GetMark_Service.HostPath = Config.ServerMapPath(string.Empty);
                this.MainHost = new ServiceHost(typeof(GetMark_Service));
                this.MainHost.Open();
                lblMessage.Text = "Service is starting";
                lblMessage.ForeColor = Color.Green;
                btnStart.Enabled = false;
                btnStop.Enabled = true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "Error", MessageBoxButtons.OK);
            }
            /*
            Uri baseAddress = new Uri("http://localhost:8001/MarkManagementService");
            Type contractType = typeof(IService);
            Type instanceType = typeof(MarkManagementService);
            host = new ServiceHost(instanceType, baseAddress);

            // Create basicHttpBinding endpoint at http://localhost:8001/MarkManagementService
            string relativeAddress = "OperationService";
            host.AddServiceEndpoint(contractType, new BasicHttpBinding(), relativeAddress);

            NetTcpBinding A = new NetTcpBinding(SecurityMode.Transport);
            host.AddServiceEndpoint(contractType, new NetTcpBinding(), "net.tcp://localhost:9000/MarkManagementService");
            host.AddServiceEndpoint(contractType, A, "net.tcp://localhost:9001/MarkManagementService");
            // Add behavior for our MEX endpoint
            //Add Mex endpoint can dung de khi client discovery thay duoc service

            ServiceMetadataBehavior behavior = new ServiceMetadataBehavior();
            behavior.HttpGetEnabled = true;
            host.Description.Behaviors.Add(behavior);

            // Add MEX endpoint at http://localhost:8000/MEX/
            host.AddServiceEndpoint(typeof(IMetadataExchange), new BasicHttpBinding(), "MEX");*/

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            StartService();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            try
            {
                this.MainHost.Close();
                lblMessage.Text = "Service closed";
                lblMessage.ForeColor = Color.Red;
                btnStart.Enabled = true;
                btnStop.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void LoadEndpointList()
        {
            this.EndpointSource.DataSource = Config.GetListConfigEnpoint();
            this.grvEndpoints.DataSource = this.EndpointSource;
        }
        private void frmMainHost_Load(object sender, EventArgs e)
        {
            LoadEndpointList();
        }

        private void btnSaveConfig_Click(object sender, EventArgs e)
        {
            BindingList<Endpoint> endpointList = (BindingList<Endpoint>)this.EndpointSource.DataSource;
            Config.SaveEndpointAddressLinQ(endpointList);
            MessageBox.Show("Save success at " +  DateTime.Now.ToShortTimeString(), 
                "System", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string binding = cboBinding.Text;
            string address = "";
            switch (binding.ToUpper())
            {
                case "BASICHTTPBINDING":
                case "WSHTTPBINDING":
                case "WSDUALHTTPBINDING":
                    address = string.Format(@"http://localhost:{0}/MarkManagementService",txtEndpointLocal.Text);
                    break;
                case "NETTCPBINDING":
                    address = string.Format(@"net.tcp://localhost:{0}/MarkManagementService", txtEndpointLocal.Text);
                    break;
                case "MEXHTTPBINDING":
                    address = @"mex";
                    break;
                case "NETNAMEDPIPEBINDING":
                    address = @"net.pipe://localhost/MarkManagementService";
                    break;
                default: break;
            }
            if (address != "")
                this.EndpointSource.Add(new Endpoint(address, binding));
        }

        private void grvEndpoints_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && grvEndpoints.Columns[e.ColumnIndex] is DataGridViewLinkColumn)
            {
                this.EndpointSource.RemoveAt(e.RowIndex);
            }
        }
    }
}
