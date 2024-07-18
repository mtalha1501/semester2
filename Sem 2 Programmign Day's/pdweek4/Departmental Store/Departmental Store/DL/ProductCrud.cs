using Departmental_Store.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Departmental_Store.DL
{
    internal class ProductCrud
    {
        public List<BL.Product> produtcs = new List<BL.Product>(); 
        public void AddProduct(Product p)
        {
            produtcs.Add(p);
        }
        public void ExtendStock(Product p,int num)
        {
            p.NumProduct += num;
        }
    }
}
