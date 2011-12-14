using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;
namespace ServiceLibrary
{
    [DataContract]
    class InfoFault
    {
        private string type;
        private string message;
        [DataMember]
        public string Type
        {
            set { type = value; }
            get { return type; }
        }
        [DataMember]
        public string Message
        {
            set { message = value; }
            get { return message; }
        }
    }
}
