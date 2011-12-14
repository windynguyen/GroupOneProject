using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;
using Client.GetMark_Service;
namespace Client
{
    class Proxy
    {
        //private static EndpointAddress address = new EndpointAddress("http://localhost:3000/GetMark_Service");
        //private static WSHttpBinding binding = new WSHttpBinding();
        private static IService proxy;
        public static IService New_Proxy_WSHttpBingding ()
        {
            return proxy = new GetMark_Service.ServiceClient("WSHttpBinding_IService");
        }
        public static IService New_Proxy_BasicHttpBinding()
        {
            return proxy = new GetMark_Service.ServiceClient("BasicHttpBinding_IService");
        }
        public static IService New_Proxy_NetTcpBinding()
        {
            return proxy = new GetMark_Service.ServiceClient("NetTcpBinding_IService");
        }
        public static IService New_Proxy_NetNamedPipeBinding()
        {
            return proxy = new GetMark_Service.ServiceClient("NetNamedPipeBinding_IService");
        }
    }
}
