using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    internal class Staff:Person
    {
        private string school;
        private double pay;
        public Staff(string name, string address, string school, double pay) : base(name, address)
        {
            this.school = school;
            this.pay = pay;
        }
        public string GetSchool()
        {
            return school;
        }
        public void SetSchool(string s)
        {
            school = s;
        }
        public double GetPay()
        {
            return pay;
        }
        public void SetPay(double pay)
        {
            this.pay = pay;
        }
        public new string ToString()
        {
            return "Staff[Person[name = " + name + ",Address = " + address + "], School = " + school + ", Pay = " + pay +"]";
        }
    }
}
