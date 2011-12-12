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
using Client.GetMark_Service;

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

        private void SetInitComplete()
        {
            lblProgess.Visible = ptbSendResultWait.Visible = false;
        }
        private void SetInitBegin()
        {
            lblProgess.Visible = ptbSendResultWait.Visible = true;
        }
        private void btn_Author_BasHttp_Click(object sender, EventArgs e)
        {
           // try
           // {
                address = new EndpointAddress("http://localhost:" + txtLLocaBasHttp.Text + "/GetMark_Service");
                BasicHttpBinding binding = new BasicHttpBinding();
                proxy = ChannelFactory<IService>.CreateChannel(binding, address);

                lstMem = proxy.GetAuthors();
                grid_basHttp.DataSource = lstMem;
          //  }
          //  catch
          //  {
          //      MessageBox.Show("Service not responding!", "Warning", MessageBoxButtons.OK);
          //  }

        }
        private void btn_Author_WsHttp_Click(object sender, EventArgs e)
        {
            try
            {
                address = new EndpointAddress("http://localhost:" + txtLLocaWsHttp.Text + "/GetMark_Service");
                WSHttpBinding binding = new WSHttpBinding();

                proxy = ChannelFactory<IService>.CreateChannel(binding, address);
                lstMem = proxy.GetAuthors();
                grid_WsHttp.DataSource = lstMem;
            }
            catch (CommunicationException commProblem) //lỗi giao tiếp với server
            {
                MessageBox.Show("There was a communication problem. " + commProblem.Message + commProblem.StackTrace);
            }

        }
        private void btn_Author_WsDualHttp_Click(object sender, EventArgs e)
        {
            try
            {
                address = new EndpointAddress("http://localhost:" + txtLLocaWsDualHttp.Text + "/GetMark_Service");
                WSDualHttpBinding binding = new WSDualHttpBinding();

                proxy = ChannelFactory<IService>.CreateChannel(binding, address);
                lstMem = proxy.GetAuthors();
                grid_WsHttp.DataSource = lstMem;
            }
            catch (CommunicationException commProblem) //lỗi giao tiếp với server
            {
                MessageBox.Show("There was a communication problem. " + commProblem.Message + commProblem.StackTrace);
            }

        }

        private void btn_Author_NetTcp_Click(object sender, EventArgs e)
        {
            try
            {
                address = new EndpointAddress("net.tcp://localhost:" + txtLLocaNetTcp.Text + "/GetMark_Service");

                NetTcpBinding binding = new NetTcpBinding();

                proxy = ChannelFactory<IService>.CreateChannel(binding, address);
                lstMem = proxy.GetAuthors();
                grid_netTcp.DataSource = lstMem;
            }
            catch (CommunicationException commProblem) //lỗi giao tiếp với server
            {
                MessageBox.Show("There was a communication problem. " + commProblem.Message + commProblem.StackTrace);
            }

        }
        private void btn_Author_netNamePipe_Click(object sender, EventArgs e)
        {
            try
            {
                address = new EndpointAddress("net.pipe://localhost/GetMark_Service");

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
        public NetTcpBinding configNetTcp()
        {
            NetTcpBinding binding = new NetTcpBinding();
            binding.MaxBufferPoolSize = 2147483647;
            binding.MaxReceivedMessageSize = 2147483647;
            binding.MaxBufferSize = 2147483647;
            binding.ReaderQuotas.MaxStringContentLength = 2147483647;
            binding.ReaderQuotas.MaxDepth = 2147483647;
            binding.ReaderQuotas.MaxBytesPerRead = 2147483647;
            binding.ReaderQuotas.MaxNameTableCharCount = 2147483647;
            binding.ReaderQuotas.MaxArrayLength = 2147483647;
            binding.SendTimeout = new TimeSpan(1, 10, 0);
            binding.ReceiveTimeout = new TimeSpan(1, 10, 0);
            binding.Security.Mode = SecurityMode.Transport;
            return binding;
        }
        private void btnDownloadSyn_Click(object sender, EventArgs e)
        {
            SetInitBegin();            
            try
            {
                this.address = new EndpointAddress("net.tcp://localhost:5555/GetMark_Service");
                NetTcpBinding binding = configNetTcp();
                //string pathClient = ServerMapPath(@"Resources\Than Tinh Ai.exe");

                proxy = ChannelFactory<IService>.CreateChannel(binding, address);
                //byte[] data = proxy.Download(pathServer);
                //FileStream fs = new FileStream(pathClient, FileMode.Create, FileAccess.Write);
                //fs.Write(data, 0, (int)data.Length);
                //fs.Close();
            }
            catch
            {
                MessageBox.Show("Service not responding!", "Warning", MessageBoxButtons.OK);
            }

        }
        void Download_CallBack(Object sender, GetMark_Service.DownloadCompletedEventArgs e)
        {
            //txtLLocaBasHttp.Text = "fd";
            int a = e.Result;
            //FileStream fs = new FileStream(pathClient, FileMode.Create, FileAccess.Write);
            //fs.Write(data, 0, (int)data.Length);
            //fs.Close();
            SetInitComplete();
            MessageBox.Show("ok "+ a.ToString());
        }
        void GetResource_CallBack(Object sender, GetMark_Service.GetResourceCompletedEventArgs e)
        {
            SetInitComplete();
            byte[] data = e.Result;
            dialogSaveDownload.FileName = FILE_NAME;
            if (dialogSaveDownload.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllBytes(dialogSaveDownload.FileName, e.Result);
            }
        }
        public const string FILE_NAME = "Penguins.jpg";
        private void btnDownloadAsyn_Click(object sender, EventArgs e)
        {
            SetInitBegin();
            GetMark_Service.ServiceClient service =
                new GetMark_Service.ServiceClient("WSHttpBinding_IService");// cac binding khac ko dung duoc
            service.GetResourceCompleted +=
                new EventHandler<GetMark_Service.GetResourceCompletedEventArgs>(GetResource_CallBack);
            service.GetResourceAsync(FILE_NAME);//Hinh trong ServiceHost_Form/Sources
        }
    }
}
