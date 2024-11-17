using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToolShop_DLL;
using ToolShop_DLL.BL;
using ToolShop_DLL.DL;
using ToolShop_DLL.DL.DB;
using ToolShop_DLL.Interfaces;

namespace MyApp
{
    public class Object_Handler
    {
        private static I_User user = UserDB.GetInstance();
        private static I_Manager manager = ManagerDB.GetInstance();
        private static I_Tool tool = ToolDB.GetInstance();
       

        public static I_User Get_User() 
        {
            return user;
        }
        public static I_Manager Get_Manager()
        {
            return manager;
        }
        public static I_Tool Get_Tool()
        {
            return tool;
        }
    }
}
