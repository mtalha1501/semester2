using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToolShop_DLL.BL
{
    public class Cart
    {
        List<Tool> cart;
        public Cart() 
        {
            cart = new List<Tool>();
        }
        public void AddToolToCart(Tool tool)
        {
            cart.Add(tool);
        }
        public void ClearCart()
        {
            cart.Clear();
        }
        public List<Tool> GetCart()
        {
            return cart;
        }
        public bool CheckCart()
        {
            return cart.Count > 0;
        }
        public int GetTotalCartAmount()
        {
            int total = 0;
            foreach (Tool t in cart)
            {
                total += t.GetToolPrice() * t.GetQuantity();
            }

            return total;
        }
    }
}
