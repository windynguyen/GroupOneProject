using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace ServiceLibrary
{
    class connect
    {
        private static string strcon = @"Data Source=.\SQLEXPRESS;Initial Catalog=GetMark_Service;Integrated Security=True";
        static public SqlConnection con;
        public static string getStrcon()
        {
            return strcon;
        }
        public static void Open_Connect()
        {
            con = new SqlConnection(strcon);
            con.Open();
        }
        public static void Close_Connect()
        {
            con.Close();
        }
    }
}
