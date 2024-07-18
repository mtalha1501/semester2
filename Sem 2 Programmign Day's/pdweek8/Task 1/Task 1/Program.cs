using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student("Talha", "UET", "CS", 23, 60000);
            s1.SetYear(1);  
            s1.GetName();
            s1.GetName();
            Console.ReadKey();
        }
    }
}
