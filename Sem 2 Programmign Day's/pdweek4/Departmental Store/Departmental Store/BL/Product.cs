using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Departmental_Store.BL
{
    internal class Product
    {
        public string ProductName;
        public float ProductPrice;
        public int NumProduct;
        public List<BL.Product> produtcs = new List<BL.Product>();

        public Product(string productName, float productPrice, int numProduct)
        {
            ProductName = productName;
            ProductPrice = productPrice;
            NumProduct = numProduct;
        }
        public void AddProduct(Product p)
        {
            produtcs.Add(p);
        }
        public void ExtendStock(Product p, int num)
        {
            p.NumProduct += num;
        }

    }
}
