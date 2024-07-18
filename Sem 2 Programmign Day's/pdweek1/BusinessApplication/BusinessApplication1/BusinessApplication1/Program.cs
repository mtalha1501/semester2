using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessApplication1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var items_list = new string[30];
            var items_bought = new int[30];
            int items_index = 2;
            
            items_list[0] = "cake"; items_list[1] = "lays";
            var items_prices = new int[30];
            items_prices[0] = 30; items_prices[1] = 60;

             // DataBases

            var user_Names_data = new string[30];
            var password_data = new string[30];
            var roles_data = new string[30];

            int userName_index = 0;

            // Admin Code:
            string admin_code = "abcd";


            Console.ReadLine();
            StartMenu(user_Names_data,password_data,roles_data,ref userName_index,ref admin_code,ref items_list,ref items_index,ref items_bought,ref items_prices);
        }
        static void StartMenu(string[] userNames_data,string[] password_data,string[] roles_Data,ref int userName_index,ref string AdminCode,ref string[] items_list,ref int items_index,ref int[] items_bought,ref int[] items_prices)
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
                    SignIn(userNames_data, password_data, roles_Data, userName_index, ref items_list, ref items_index, ref items_bought, ref items_prices);
                }
                else if (option == 2)
                {
                    SignUPvoid(userNames_data, password_data, roles_Data, ref userName_index, ref AdminCode);
                }
                else if (option == 3)
                {
                    break;
                }
            }
            

        }
        static void SignUPvoid(string[] userName_data, string[] password_data, string[] roles_data,ref int userName_index, ref string AdminCode)
        {
            string userName, passWord,role, admin_code;
            Console.Write("Enter Username: ");
            userName = Console.ReadLine();
            if(!IsAlreadyUser(userName,userName_data,userName_index))
            {
                Console.Write("Enter Password: ");
                passWord = Console.ReadLine();
                Console.Write("Enter Role (user or manager): ");
                role = Console.ReadLine();

                string signUpChecker = SignUp(passWord,role);
                if(signUpChecker == "password length less than 6")
                {
                    Console.WriteLine("Password Length Should be greater or equal to 6");
                }
                else if(signUpChecker == "incorrect role")
                {
                    Console.WriteLine("Role is incorrect, must be a \"user\" or \"manager\"");
                }
                else if (signUpChecker == "user")
                {
                    userName_data[userName_index] = userName;
                    password_data[userName_index] = passWord;
                    roles_data[userName_index] = role;
                    userName_index++;
                }
                else if (signUpChecker == "manager")
                {
                    Console.Write("Enter ADMIN CODE: ");
                    admin_code = Console.ReadLine();
                    if (admin_code == AdminCode)
                    {
                        userName_data[userName_index] = userName;
                        password_data[userName_index] = passWord;
                        roles_data[userName_index] = role;
                        userName_index++;
                    }
                    else
                    {
                        Console.WriteLine("Incorrect Admin Code..");
                    }
                }
                

            }
            else
            {
                Console.WriteLine("This username already exists.. Try Different");
            }

        }
        static string SignUp(string password,string role)
        {
            if(password.Length >= 6)
            {
                if(role == "manager" || role == "user")
                {
                    if(role == "manger")
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
        static void SignIn(string[] userNames_data,string[] password_data, string[] roles_data,int userName_index,ref string[] items_list,ref int items_index,ref int[] items_bought,ref int[] items_prices)
        {
            string username, password;
            Console.Write("Enter your username: ");
            username = Console.ReadLine();
            if (IsAlreadyUser(username, userNames_data, userName_index))
            {
                Console.Write("Enter your password: ");
                password = Console.ReadLine();
                string SignInChecker = SignIn(username,password,userNames_data,password_data,roles_data,userName_index);
                if(SignInChecker == "password incorrect")
                {
                    Console.WriteLine("Password is Incorrect..");
                }
                else if(SignInChecker == "manager")
                {

                }
                else if(SignInChecker == "user")
                {
                    UserMenu(items_list, items_index, items_bought, items_prices);
                }
            }
            else
            {
                Console.WriteLine("Username is Incorrect");
            }
        }
        static string SignIn(string username,string password,string[] userNames_data,string[] password_Data, string[] roles_data,int userName_index)
        {
            int userIndex = UserNameIndexGetter(username, userNames_data, userName_index);
            if (password == password_Data[userIndex])
            {
                if (roles_data[userIndex] == "manager")
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
        static int UserNameIndexGetter(string username, string[] userNames_data,int Username_index)
        {
            for(int i = 0; i < Username_index; i++)
            {
                if (username.Equals(userNames_data[i]))
                {
                    return i;
                }
            }
            return -1;
        }
        static bool IsAlreadyUser(string username,string[] usernames_data, int UserName_index)
        {
            for(int i = 0 ; i < UserName_index; i++)
            {
                if (username.Equals(usernames_data[i])) 
                {
                    return true;
                }
            }
            return false;
        }
        static void UserMenu(string[] items_list,int items_index,int[] items_bought, int[] items_prices)
        {
            MainHeader();
            int option;
            Console.WriteLine("What do you want to do: ");
            Console.WriteLine("1. See Rate List  \n2. Buy Items  \n3. Check My Cart  \n4. Pay Bill  ");
            option = Convert.ToInt32(Console.ReadLine());
            if(option == 1)
            {
                PrintItemRates(items_list,items_index);
            }
        }
        static void PrintItemRates(string[] items_list,int items_index)
        {
            MainHeader();
            Console.WriteLine("\n\n             >>>>>>>> Item Menu <<<<<<<<            ");
            Console.WriteLine("  Sr " + "     Item Name");
            for(int i = 0; i < items_index; i++)
            {
                Console.WriteLine("  " + (i+1) + ".     " + items_list[i]);
            }
        }
        
        static void BuyItems(string[] items_list,int[] items_bought,int items_index)
        {
            MainHeader();
            int option = 0, number;
            PrintItemRates(items_list,items_index);
            while(option != 9)
            {
                Console.Write("Enter the index of Item ( Enter " + (items_index + 1) + "when Done) :");
                option = Convert.ToInt32(Console.ReadLine());
                if (option > items_index)
                {
                    Console.WriteLine("Invalid Option");
                }
                else
                {
                    Console.Write("Enter Quantity: ");
                    number = Convert.ToInt32(Console.ReadLine());
                    items_bought[option - 1] += number;
                }
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
