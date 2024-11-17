using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToolShop_DLL.DL.DB
{
    public class DbConnConfig
    {
        public static string connection()
        {
            string conn = "Data Source=DESKTOP-UEUCV49\\SQLEXPRESS01;Initial Catalog=Tool_Shop;Integrated Security=True";
            return conn;
        }
    }
}
