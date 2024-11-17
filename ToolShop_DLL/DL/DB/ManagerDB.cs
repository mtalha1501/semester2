using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToolShop_DLL.BL;
using ToolShop_DLL.Interfaces;

namespace ToolShop_DLL.DL.DB
{
    public class ManagerDB:I_Manager
    {
        private List<Manager> managers = new List<Manager>();
        private static ManagerDB instance;
        public static ManagerDB GetInstance()
        {
            if (instance == null)
            {
                instance = new ManagerDB();
            }
            return instance;
        }
        public List<Manager> GetManagers()
        {
            return managers;
        }
        public void RemoveUser(User u)
        {
            UserDL.users.Remove(u);
        }
        public void AddUser(User u)
        {
            UserDL.users.Add(u);
        }

        public User FindUser(User u)
        {
            foreach (User stored in UserDL.users)
            {
                if (u.GetUsername() == stored.GetUsername() && u.GetPassword() == stored.GetPassword())
                { return stored; }
            }
            return null;
        }

    }
}
