using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToolShop_DLL.BL;
using ToolShop_DLL.Interfaces;

namespace ToolShop_DLL.DL
{
    public class UserDL
    {
        
        public static List<User> users = new List<User>();
        public static List<Manager> managers = new List<Manager>();
        public static List<Customer> customers = new List<Customer>();

        
        public static bool CheckAdmin(string name) 
        {
            foreach (Manager ad in users)
            {
                if (ad.GetUsername() == name)
                {
                    return true;
                }
            }
            return false;
        }
        public static bool CheckCustomer(string name)
        {
            foreach (Customer cu in customers)
            {
                if (cu.GetUsername() == name)
                {
                    return true;
                }
            }
            return false;
        }
        public static Manager GetAdminWithUsername(string userName)
        {
            foreach (Manager ad in managers)
            {
                if (ad.GetUsername() == userName)
                {
                    return ad;
                }
            }
            return null;
        }
        public static Customer GetCustomerWithUsername(string userName)
        {
            foreach (Customer ad in users)
            {
                if (ad.GetUsername() == userName)
                {
                    return ad;
                }
            }
            return null;
        }
        public static bool CheckUser(string username,string password)
        {
            foreach(User u in users)
            {
                if(u.GetUsername() == username && u.GetPassword() == password)
                {
                    return true;
                }
            }
            return false;
        }
        public void AddUser(User admin)
        {
            
            users.Add(admin);
        }
        public void RemoveUser(User admin)
        {
            users.Remove(admin);
        }
        

    }
}
