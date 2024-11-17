using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToolShop_DLL.BL
{
    public class Manager:User
    {
        List<Tool> ToolsList = new List<Tool> ();
        public Manager(string username,string password,string role,string age,string phone):base(username,password,role,age,phone)
        {
            ToolsList = new List<Tool> ();
        }
        
    }
}
