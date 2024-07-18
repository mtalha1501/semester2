using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessApp2
{
    internal class Product
    {
        public Product(string Name,string Brand,float Price)
        {
            name = Name;
            brand = Brand;
            price = Price;
        }

        public string name;
        public float price;
        public string brand;
    }

}
