using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Departmental_Store.BL
{
    internal class Customer
    {
        public string Name;
        public string LoginID;
        public string Email;
        public string PhoneNumber;
        public string Address;
        public Customer(string name, string loginID, string email, string phoneNumber, string address)
        {
            Name = name;
            LoginID = loginID;
            Email = email;
            PhoneNumber = phoneNumber;
            Address = address;
        }
    }
}
