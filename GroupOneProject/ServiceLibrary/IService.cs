using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Net.Security;

namespace ServiceLibrary
{
    //Interface Service: định nghĩa các hàm cung cấp cho client
    [ServiceContract]
    public interface IService
    {
        [OperationContract]
        List<Member> GetAuthors();
        [OperationContract]
        int Download(string path);
        [OperationContract]
        byte[] GetResource(string resName);
    }
    [DataContract]
    public class Member
    {
        private string code;
        private string fullname;
        private string _class;

        [DataMember]
        public string Code
        {
            get { return code; }
            set { code = value; }
        }
        [DataMember]
        public string FullName
        {
            get { return fullname; }
            set { fullname = value; }
        }
        [DataMember]
        public string _Class
        {
            get { return _class; }
            set { _class = value; }
        }

        public Member(string _code, string _fullname, string __class)
        {
            this.code = _code;
            this.fullname = _fullname;
            this._Class = __class;
        }
    }
}
