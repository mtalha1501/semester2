using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ToolShop_DLL.Utilities
{
    public class Validations
    {
        public static void Return()
        {
            Console.Write("Press any key to return...");
            Console.Read();
        }
        public static bool Validateint(string name)

        {
            bool check = false;
            for (int i = 0; i < name.Length; i++)
            {
                if (name[i] >= '0' && name[i] <= '9')
                {
                    check = true;
                }
                else
                {
                    return false;
                }
            }
            return check;
        }
        public static string ValidatePassword(string password)
        {
            while (CheckforEmpty(password) || CheckingForSpace(password) || !CheckPassword(password))
            {
                if (!CheckPassword(password))
                {
                    Console.WriteLine("The password is must contain Eight Digits or Alpabets");
                }

                if (CheckingForSpace(password))
                {
                    Console.WriteLine("Password should not contain spaces.");
                }

                if (CheckforEmpty(password))
                {
                    Console.WriteLine("Password should not be empty.");
                }
                Console.Write("Enter password again: ");
                password = Console.ReadLine();
            }

            return password;


        }
        public static bool CheckPassword(string password)
        {
            string pattern = @"^[a-zA-Z0-9]{8}$";
            return Regex.IsMatch(password, pattern);
        }
        public static string ValidateRole(string role)
        {
            while (CheckforEmpty(role) || !CheckRole(role))
            {
                if (CheckforEmpty(role))
                {
                    Console.WriteLine("Role Should not be empty");
                }
                if (!CheckRole(role))
                {
                    Console.WriteLine("Please write Customer or Employee");
                }
                Console.WriteLine("Enter Role Again: ");
                role = Console.ReadLine();
            }
            return role;
        }
        public static string Roleteller(string input)
        {
            string lowercaseInput = input.ToLower();

            if (lowercaseInput == "customer")
            {
                return "customer";
            }
            else
            {
                return "employee";

            }

        }

        public static bool CheckRole(string input)
        {
            string lowercaseInput = input.ToLower();

            if (lowercaseInput == "customer")
            {
                return true;
            }
            else if (lowercaseInput == "employee")
            {
                return true;

            }
            else
            {
                return false;
            }
        }
        public static bool IsValid(string type, string check, bool flag = true)
        {
            if (string.IsNullOrWhiteSpace(check))
            {
                UtilityUI.Error($"{type} can't be empty", false);
                return false;
            }
            else if (check.Length < 3)
            {
                UtilityUI.Error($"{type} should at least contain 3 characters", false);
                return false;
            }
            else if (check.Length > 20)
            {
                UtilityUI.Error($"{type} should be less than 20 characters", false);
                return false;
            }
            else if (check.Contains(" "))
            {
                UtilityUI.Error($"{type} can't have a space", false);
                return false;
            }
            if (flag)    // check for username and password
            {
                if (check.Any(char.IsDigit))
                {
                    UtilityUI.Error($"{type} can't have a number", false);
                    return false;
                }

                else if (ContainsSymbol(check))
                {
                    UtilityUI.Error($"{type} can't have a special character", false);
                    return false;
                }
            }
            else
            {
                if (check.Contains(","))
                {
                    UtilityUI.Error($"{type} can't have comma(,)", false);
                    return false;
                }
            }
            return true;
        }
        private static bool ContainsSymbol(string str)
        {
            foreach (char c in str)
            {
                if (!char.IsLetterOrDigit(c) && c != ' ')
                    return true;
            }
            return false;
        }
        public static string ValidateNames(string name)
        {
            while (CheckforEmpty(name) || CheckingForSpace(name))
            {
                if (CheckforEmpty(name))
                {
                    Console.WriteLine("It must not be empty.");
                }

                if (CheckingForSpace(name))
                {
                    Console.WriteLine("It must not contain a space.");
                }
                Console.Write("Enter again: ");
                name = Console.ReadLine();
            }

            return name;


        }
        static bool CheckingForSpace(string sen)
        {
            for (int x = 0; x < sen.Length; x++)
            {
                if (sen[x] == ' ')
                {
                    return true;
                }
            }
            return false;
        }

        static bool CheckforEmpty(string sen)
        {
            if (sen == "")
            {
                return true;
            }

            return false;
        }
        public static bool CheckNumber(string enter)
        {
            for (int i = 0; i < enter.Length; i++)
            {
                if (i == 0 && enter[i] != '1' && enter[i] != '2' && enter[i] != '3' && enter[i] != '4' && enter[i] != '5' && enter[i] != '6' && enter[i] != '7' && enter[i] != '8' && enter[i] != '9' && enter[i] != '.')
                {
                    UtilityUI.Error($"Invalid {enter}");
                    return false;
                }
                else if (i != 0 && enter[i] != '0' && enter[i] != '1' && enter[i] != '2' && enter[i] != '3' && enter[i] != '4' && enter[i] != '5' && enter[i] != '6' && enter[i] != '7' && enter[i] != '8' && enter[i] != '9' && enter[i] != '.')
                {
                    UtilityUI.Error($"Invalid {enter}");
                    return false;
                }
            }
            return true;
        }
    }
}
