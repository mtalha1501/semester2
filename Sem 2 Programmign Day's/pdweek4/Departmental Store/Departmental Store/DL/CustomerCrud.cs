using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Departmental_Store
{
    internal class CustomerCrud
    {
        public List<Customer> CustomerInfo = new List<Customer>();

        public static void addUser(Customer customer)
        {
            CustomerInfo.Add(customer);
        }
    }
}
