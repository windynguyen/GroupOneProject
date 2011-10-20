using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ServiceLibrary
{
    [ServiceBehavior(IncludeExceptionDetailInFaults = true)]
    public class MarkManagementService : IService
    {
        public MarkManagementService() { }
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
    }
}
