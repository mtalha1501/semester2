using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessApp2
{
    internal class User
    {
        public User(string userName,string Password,string Role)
        {
            username = userName;
            password = Password;
            role = Role;
        }
        public string username;
        public string password;
        public string role;
    }
}
