using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Departmental_Store.BL
{
    internal class Admin
    {
        public string LoginID;
        public string password;
        public void AdMenu()
        {
            Console.WriteLine(@"
        1. Add Product.
        2. View All Products.
        3. Find Product with Highest Unit Price.
        4. View Sales Tax of All Products.
        5. Products to be Ordered. (less than threshold)
        6. View Profile (Username, Password)
        7. Exit");
        }
    }
}
