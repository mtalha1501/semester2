using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToolShop_DLL.BL;
using ToolShop_DLL.Interfaces;

namespace ToolShop_DLL
{
    public class UserDB:I_User
    {
        List<User> users = new List<User>();

        private static UserDB instance;
        public static UserDB GetInstance()
        {
            if(instance == null)
            {
                instance = new UserDB();
            }
            return instance;
        }

        public List<User> GetUsers()
        {
            return users;
        }


    }
}
