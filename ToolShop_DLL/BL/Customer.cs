using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToolShop_DLL.BL
{
    public class Customer:User
    {
      
        Cart cart;
        public Customer(string username, string password, string role, string age, string phone) : base(username, password, role, age, phone)
        {
            cart = new Cart();
            
        }
        public Cart GetCart()
        {
            return cart;
        }
        public void AddToolToBoughtList(Tool t)
        {
            cart.AddToolToCart(t);
        }
       
        public void UpdateProfile(string username,string password,string phone)
        {
                SetPassword(password);
                SetPhone(phone);
                SetUsername(username);
        }

    }
}
