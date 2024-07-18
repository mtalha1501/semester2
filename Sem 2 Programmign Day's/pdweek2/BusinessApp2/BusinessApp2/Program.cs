using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BusinessApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int user_Index = 0;
            int product_index = 1;
            List<User> users = new List<User>();
            List<Product> products = new List<Product>();
            int[] bought_pro = new int[50];
            int[] numPro = new int[50];

            //For checking
            Product one = new Product("Lays","Potato",30);
            products.Add(one);

            int RuningUser_Index = 0;
            string Ad_code = "abc";
            StartMenu(users,ref user_Index,ref Ad_code,ref product_index,bought_pro, numPro,ref products,ref RuningUser_Index);
            
        }
        static void StartMenu(List<User> user_data, ref int user_index, ref string Ad_Code, ref int product_index, int[] bought_pro,int[]numPro, ref List<Product>product,ref int RuningUsr_index)
        {
            MainHeader();
            int option;

            while (true)
            {
                MainHeader();
                Console.WriteLine("1.Sign In \n2.Sign Up \n3.Exit");
                option = Convert.ToInt32(Console.ReadLine());
                if (option == 1)
                {
                    SignInvoid(user_data,user_index, bought_pro, numPro,ref product,ref product_index,ref RuningUsr_index);
                }
                else if (option == 2)
                {
                    SignUpvoid(user_data, ref user_index, ref Ad_Code);
                }
                else if (option == 3)
                {
                    break;
                }
            }
        }
        static void SignUpvoid(List<User>user_data,ref int user_Index,ref string Ad_code)
        {
            Console.Clear();
            MainHeader();
            string username, password, role,adminCode;

            
            Console.Write("Enter username: ");
            username = Console.ReadLine();
            if (!IsAlreadyUser(username,user_data, user_Index))
            {
                Console.Write("Enter password: ");
                password = Console.ReadLine();
                Console.Write("Enter role (\"user\" or \"manager\"): ");
                role = Console.ReadLine();
                string sign_up = SignUp(password, role);
                
                if(sign_up == "user")
                {
                    User newuser = new User(username, password,role);
                    user_data.Add(newuser);
                    user_Index++;
                    Console.WriteLine("Signed Up Sucessully");
                    Console.ReadLine();
                }
                if(sign_up == "manager")
                {
                    Console.Write("Enter Admin Code: ");
                    adminCode = Console.ReadLine();
                    if(adminCode == Ad_code)
                    {
                        User new_user = new User(username, password, role);
                        user_data.Add(new_user);
                        user_Index++;
                        Console.WriteLine("Signed Up Sucessully");
                        Console.ReadLine();
                    }
                    else
                    {
                        Console.WriteLine("Incorrect Admin Code");
                        Console.ReadLine();
                    }
                }
            }
            else
            {
                Console.WriteLine("This username already exists");
            }
        }
        static string SignUp(string password, string role)
        {
            if (password.Length >= 6)
            {
                if (role == "manager" || role == "user")
                {
                    if (role == "manger")
                    {
                        return "manager";
                    }
                    else
                    {
                        return "user";
                    }
                }
                else
                {
                    return "incorrect role";
                }
            }
            else
            {
                return "password length less than 6";
            }
        }
        static void SignInvoid(List<User>user_data,int user_Index,int[] bought_pro,int[]numPro,ref List<Product>product,ref int product_index,ref int RuningUsr_idx)
        {
            string username, password;
            Console.Write("Enter your username: ");
            username = Console.ReadLine();
            if (IsAlreadyUser(username, user_data, user_Index))
            {
                Console.Write("Enter your password: ");
                password = Console.ReadLine();
                string SignInChecker = SignIn(username, password, user_data, user_Index,ref RuningUsr_idx);
                if (SignInChecker == "password incorrect")
                {
                    Console.WriteLine("Password is Incorrect..");
                }
                else if (SignInChecker == "manager")
                {
                    Console.WriteLine("Manager"); 
                    Console.ReadLine();
                }
                else if (SignInChecker == "user")
                {
                    Console.WriteLine("User");
                    UserMenu(product,product_index,bought_pro,numPro);
                    Console.ReadLine();
                }
            }
            else
            {
                Console.WriteLine("Username is Incorrect");
            }
        }
        static string SignIn(string username, string password, List<User> user_data, int user_index,ref int RuningUsr_idx)
        {
            int userIndex = UserNameIndexGetter(username, user_data, user_index);
            RuningUsr_idx = userIndex;
            if (password == user_data[userIndex].password)
            {
                if (user_data[userIndex].role == "manager")
                {
                    return "manager";
                }
                else
                {
                    return "user";
                }
            }
            else
            {
                return "password incorrect";
            }

        }

        static bool IsAlreadyUser(string username, List<User> user_data, int UserName_index)
        {
            for (int i = 0; i < UserName_index; i++)
            {
                if (username.Equals(user_data[i].username))
                {
                    return true;
                }
            }
            return false;
        }
        static int UserNameIndexGetter(string username, List<User> user_data, int Username_index)
        {
            for (int i = 0; i < Username_index; i++)
            {
                if (username.Equals(user_data[i].username))
                {
                    return i;
                }
            }
            return -1;
        }

        static string ParseData(string data,int field)
        {
            int commaCount = 1;
            string item = "";
            for(int i = 0; i < data.Length; i++)
            {
                if (data[i] == ',')
                {
                    commaCount++;
                }
                if(commaCount == field)
                {
                    item += data[i];
                }
            }
            return item;
        }
       /*static void ReadData(string path, List<User> user_Data)
        {
            if (File.Exists(path))
            { 
                StreamReader varfile = new StreamReader(path);
                string record;
                while ((record = varfile.ReadLine()) != null)
                {
                    //code
                }
            }
            else
            {
                Console.WriteLine("File does not exists");
            }
        }*/
        static void UserMenu(List<Product> product, int product_index,int[] bought_pro, int[] numPro)
        {
            MainHeader();
            int option;


            Console.WriteLine("What do you want to do: ");
            Console.WriteLine("1. See Rate List  \n2. Buy Items  \n3. Check My Cart  \n4. Pay Bill  \n5.App Settings");
            option = Convert.ToInt32(Console.ReadLine());
            if (option == 1)
            {
                PrintItemRates(product, product_index);
            }
            else if(option == 2)
            {
                BuyItems(product,bought_pro,numPro,product_index);
            }
            else if(option == 3)
            {
                checkMyCart(product, bought_pro,numPro);
            }
        }
        static void PrintItemRates(List<Product> product, int product_index)
        {
            MainHeader();
            Console.WriteLine("\n\n             >>>>>>>> Item Menu <<<<<<<<            ");
            Console.WriteLine("  Sr " + "     Item Name      Price");
            for (int i = 0; i < product_index; i++)
            {
                Console.WriteLine("  " + (i + 1) + ".     " + product[i].name + "    " + product[i].price);
            }
            Console.ReadLine();
        }
        static void BuyItems(List<Product> product,int[] bought_products,int[] numProducts,int product_index)
        {           
            MainHeader();
            int option = 0, number;
            PrintItemRates(product, product_index);
   
            while (option != 9)
            {
                Console.Write("Enter the index of Item ( Enter " + (product_index + 1) + "when Done) :");
                option = Convert.ToInt32(Console.ReadLine());

                
                if(option > product_index+1)
                {
                    Console.WriteLine("Invalid Option...");
                }
                else if(option == product_index + 1)
                {
                    break;
                }
                else
                {
                    bought_products[option - 1] = option;
                    Console.Write("Enter Quantity: ");
                    number = Convert.ToInt32(Console.ReadLine());

                    numProducts[option-1] += number;
                }
            }
            Console.ReadLine();
        }
        static void checkMyCart(List<Product> products,int[] bought_pro,int[] numPro)
        {
            Console.WriteLine("Sr     Product Name      Quantity        Price       Total");
            for(int i = 0; i < bought_pro.Length; i++)
            {
                Console.Write((i + 1) + "    " + products[bought_pro[i]] + "      " + numPro[i] + "     " + products[bought_pro[i]].price + "     " + (numPro[i] * products[bought_pro[i]].price));
            }
            Console.ReadLine();
        }
        static void ManagerMenu()
        {

            Console.WriteLine("What do you want to do: ");
            Console.Write("1.Check Listed items \n2.Show All users \n3.Change Admin Code  \n4.App Settings");
        }
        static void AddProduct(List<Product> products,ref int product_index)
        {
            string name, brand;
            float price; 
            int num,option;
            Console.Write("How many products you want to add (Enter Number): ");
            num = Convert.ToInt32(Console.ReadLine());
            for(int i = 0; i<num; i++)
            {
                Console.WriteLine("Product "+(i+1));
                Console.Write("Enter Product Name: ");
                name = Console.ReadLine();
                Console.Write("Enter Brand Name: ");
                brand = Console.ReadLine();
                Console.Write("Enter Price: ");
                price = float.Parse(Console.ReadLine());
                
                Console.Write("\n\nName: " + name + "\nBrand: " + brand + "\nPrice: " + price);
                Console.Write("1.Confirm   \n2.Cancel");
                option = Convert.ToInt32(Console.ReadLine());
                if(option == 1)
                {
                    Product newProduct = new Product(name, brand, price);
                    products.Add(newProduct);
                    product_index++;

                    Console.Write(name + " Added Successfully...");
                    Thread.Sleep(1000);
                }
                else
                {
                    continue;
                }
                Console.Clear();
                MainHeader();
            }
        }
        static void ShowAllUsers(List<User> users)
        {
            Console.WriteLine("Sr      Name      Role");
            for(int i = 0; i < users.Count; i++)
            {
                Console.WriteLine((i+1) +"    "+ users[i].username + "   " + users[i].role);
            }
        }
        static void changeAdminCode(ref string Ad_Code)
        {
            string new_code = "";
            Console.Write("Enter new Admin Code: ");
            new_code = Console.ReadLine();
            Ad_Code = new_code;

            Console.Write("ADmin Code is changed now ..\nPress any key to go back");
            Console.ReadKey();
        }
        static void AppSettings(ref List<User>userData,int RuningUsr)
        {
            int option;
            Console.WriteLine("1.Change Password");
            option = Convert.ToInt32(Console.ReadLine());   
            if(option == 1)
            {
                changePassword(ref userData,RuningUsr);
            }
            Console.ReadKey();
        }
        static void changePassword(ref List<User> userData,int RuningUsr_idx)
        {
            string old_pas;
            Console.Write("Enter your previous Password: ");
            old_pas = Console.ReadLine();
            if (userData[RuningUsr_idx].password == old_pas)
            {
                string new_PAS;
                Console.Write("Enter new Password: ");
                new_PAS = Console.ReadLine();
                userData[RuningUsr_idx].password = new_PAS;
                Console.Write("Password Changed Successfully..\nPress any key to exit");
                Console.ReadKey();
            }
            else
            {
                Console.Write("Old password didn't matched...\nTry Again Later.");
                Thread.Sleep(1000);
                return;
            }
        }
        static void MainHeader()
            {
                Console.Clear();
                Console.WriteLine(@"
            #############################################################################################################################################
            ##-----------------------------------------------------------------------------------------------------------------------------------------##
            ##                           ______                                        __          _____    __                                         ##
            ##                          / ____/  ___    ____   ___    _____  ____ _   / /         / ___/   / /_   ____     ____                        ##
            ##                         / / __   / _ \  / __ \ / _ \  / ___/ / __ `/  / /          \__ \   / __ \ / __ \   / __ \                       ##
            ##                        / /_/ /  /  __/ / / / //  __/ / /    / /_/ /  / /          ___/ /  / / / // /_/ /  / /_/ /                       ##
            ##                        \____/   \___/ /_/ /_/ \___/ /_/     \__,_/  /_/          /____/  /_/ /_/ \____/  / .___/                        ##
            ##                                                                                                         /_/                             ##
            ##-----------------------------------------------------------------------------------------------------------------------------------------##
            ############################################################################################################################################# ");
            }  
    }
}
