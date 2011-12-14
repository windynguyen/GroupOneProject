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
            catch (CommunicationException commProblem) //lỗi giao tiếp với server
            {
                MessageBox.Show("There was a communication problem. " + commProblem.Message + commProblem.StackTrace);
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
            catch (CommunicationException commProblem) //lỗi giao tiếp với server
            {
                MessageBox.Show("There was a communication problem. " + commProblem.Message + commProblem.StackTrace);
            }
        }

        private void LoadResource()
        {
            List<string> lstResource = this.proxy.GetResourcesList().ToList<string>();
            for (int i = 0; i < lstResource.Count; i++)
            {
                string x = lstResource.GetRange(i, 1).FirstOrDefault();
                if (!x.StartsWith(GlobalVariable.Username))
                    lstResource.RemoveAt(i);
            }
                
            lsbDocument.DataSource = lstResource;
        }
        private void lnkGetList_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LoadResource();
        }
        private string FileNameSelected = "";
        private void lnkDownload_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.FileNameSelected = lsbDocument.SelectedItem.ToString();
            ptbSendResultWait.Visible = true;

            GetMark_Service.ServiceClient service =
                new GetMark_Service.ServiceClient("WSHttpBinding_IService");
            // cac binding khac ko dung duoc
            service.DownloadResourceCompleted +=
                new EventHandler<GetMark_Service.DownloadResourceCompletedEventArgs>(GetResource_CallBack);
            service.DownloadResourceAsync(FileNameSelected);
        }
        //Nhận phản hồi từ DownloadResource
        void GetResource_CallBack(Object sender, GetMark_Service.DownloadResourceCompletedEventArgs e)
        {
            ptbSendResultWait.Visible = false;
            byte[] data = e.Result;
            dlgSaveDownload.FileName = FileNameSelected;
            if (dlgSaveDownload.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllBytes(dlgSaveDownload.FileName, e.Result);
            }
        }
        private void lsbDocument_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!lnkDownload.Enabled) lnkDownload.Enabled = true;
        }

        private void lnkUpload_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (dlgOpenUpload.ShowDialog() == DialogResult.OK)
            {
                GetMark_Service.ServiceClient service = new GetMark_Service.ServiceClient("WSHttpBinding_IService");
                service.UploadResourceCompleted += new EventHandler<GetMark_Service.UploadResourceCompletedEventArgs>(UploadResource_CallBack);

                FileInfo fi = new FileInfo(dlgOpenUpload.FileName);
                FileStream fs = File.OpenRead(dlgOpenUpload.FileName);
                byte[] bytes = new byte[fs.Length];
                fs.Read(bytes, 0, Convert.ToInt32(fs.Length));
                fs.Close();
                service.UploadResourceAsync(GlobalVariable.Username + "-" + fi.Name, bytes);
            }
        }
        void UploadResource_CallBack(Object sender, GetMark_Service.UploadResourceCompletedEventArgs e)
        {
            ptbSendResultWait.Visible = false;
            if (e.Result)
            {
                LoadResource();
                MessageBox.Show("Upload " + this.FileNameSelected + " thành công!", "Hoàn tất");
            }
            else
                MessageBox.Show("Upload " + this.FileNameSelected + " hỏng!\nXin thử lại!", "Không hoàn tất");


        }

    }
}
