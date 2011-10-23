using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Threading;

namespace ServiceLibrary
{
    [ServiceBehavior(IncludeExceptionDetailInFaults = true)]
    public class MarkManagementService : IService
    {
        public static string HostPath = "";
        public MarkManagementService() 
        {
            
        }

        public List<Member> GetAuthors()
        {
            //return danh sách nhóm
            Member mem1 = new Member("080873", "Nguyễn Thanh Phong", "PM081");
            Member mem2 = new Member("080922", "Nguyễn Đình Tín", "PM081");
            Member mem3 = new Member("080890", "Đặng Minh Thành", "PM081");
            List<Member> lst_mem = new List<Member>();
            lst_mem.Add(mem1);
            lst_mem.Add(mem2);
            lst_mem.Add(mem3);
            return lst_mem;
        }
        public int Download(string path)
        {
            /*FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read);
            byte[] buffer = new byte[fs.Length];
            fs.Read(buffer, 0, (int)fs.Length);
            Thread.Sleep(100000);*/

            return 1;
        }
        public byte[] GetResource(string resName)
        {
            //Ca 1 nghe thuat^^
            string filepath = HostPath + @"Sources\" + resName;
            FileStream fs = File.OpenRead(filepath);
            byte[] bytes = new byte[fs.Length];
            fs.Read(bytes, 0, Convert.ToInt32(fs.Length));
            fs.Close();
            return bytes;
        }
    }
}
