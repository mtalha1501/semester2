using Departmental_Store.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Departmental_Store
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int option;
            Console.WriteLine("Enter Your Choice: ");
            option = Convert.ToInt32(Console.ReadLine());
            Menu1(option);
            
        }
        static int Menu1(int op)
        {
            Console.Write("1.Sign In \n 2.Sign Up \n 3.Exit");
            if (op > 0 && op < 4)
            {
                return op;
            }
            else
            {
                return -1;
            }
        }
        static void SignIn()
        {
            string username,password;
            Console.WriteLine("Enter Username: ");
            username = Console.ReadLine();
            Console.WriteLine("Enter Password: ");
            password = Console.ReadLine();
        }
        static int Menu()
        {
            int op;
            Console.WriteLine(@"
                1. Add Product.
                2. View All Products.
                3. Find Product with Highest Unit Price.
                4. View Sales Tax of All Products.
                5. Products to be Ordered. (less than threshold)
                6. View Profile (Username, Password)
                7. Exit");
            op = Convert.ToInt32(Console.ReadLine());
            if(op > 0 && op < 8)
            {
                return op;
            }
            else
            {
                return -1;
            }
        }
    }
}
