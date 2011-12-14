using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ServiceHost_Form
{
    static class Accessories
    {
        public static string ServerMapPath(string subPath)
        {
            return Application.StartupPath.Replace(@"bin\Debug", "") + subPath;
        }
    }
}
