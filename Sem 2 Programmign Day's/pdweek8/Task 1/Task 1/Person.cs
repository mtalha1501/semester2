﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    internal class Person
    {
        protected string name;
        protected string address;
        public Person(string name, string address)
        {
            this.name = name;
            this.address = address;
        }
        public string GetName()
        {
            return name;
        }
        public string GetAddress()
        {
            return address;
        }
        public void SetAddress(string address)
        {
            this.address = address;
        }
        public new string ToString()
        {
            return "Person[name=" + name + ",address=" + address + "]";
        }
    }
}
