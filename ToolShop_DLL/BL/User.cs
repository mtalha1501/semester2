using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToolShop_DLL.BL
{
    public class User
    {
        protected string username;
        protected string password;
        protected string role;
        protected string age;
        protected string phone;
        public User(string username, string password, string role, string age, string phone)
        {
            this.username = username;
            this.password = password;
            this.role = role;
            this.age = age;
            this.phone = phone;
        }
        public string GetUsername()
        {
            return username;
        }
        public string GetPassword()
        {
            return password;
        }
        public string GetRole()
        {
            return role;
        }
        public string GetAge()
        {
            return age;
        }
        public string GetPhone()
        {
            return phone;
        }
        public void SetRole(string role)
        {
            this.role = role;
        }
        public void SetPassword(string password)
        {
            this.password = password;
        }
        public void SetUsername(string username)
        {
            this.username = username;
        }
        public void SetPhone(string phone)
        {
            this.phone = phone;
        }
        public void EditProfile(string username, string password, string email, string role)
        {
            SetUsername(username);
            SetPassword(password);
            SetPhone(email);
            SetRole(role);
        }
    }
}
