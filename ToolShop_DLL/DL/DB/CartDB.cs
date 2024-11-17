using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToolShop_DLL.BL;
using ToolShop_DLL.DL;
using ToolShop_DLL.Interfaces;

namespace ToolShop_DLL.DL.DB
{
    public class CartDB
    {
        private List<ToolDB> cart = new List<ToolDB>();
        private static CartDB instance;
        public static CartDB GetInstance()
        {
            if (instance == null)
            {
                instance = new CartDB();
            }
            return instance;
        }
        public void AddTool(ToolDB tool)
        {
            cart.Add(tool);
        }
        public void ClearCart()
        {
            cart.Clear();
        }
        public List<ToolDB> GetCart()
        {
            return cart;
        }
        public bool CheckCart()
        {
            return cart.Count > 0;
        }
        /*public int GetTotalCartAmount()
        {
            int total = 0;
            foreach (ToolDB t in cart)
            {
                total += t.GetToolPrice() * t.GetQuantity();
            }

            return total;
        }*/

    }
}
