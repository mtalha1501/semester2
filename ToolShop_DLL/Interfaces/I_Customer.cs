using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToolShop_DLL.BL;
using ToolShop_DLL.DL;

namespace ToolShop_DLL.Interfaces
{
    public interface I_Customer
    {
        Cart GetCart();
        void AddToolToBoughtList(Tool t);
        void UpdateProfile(string username, string password, string phone);
    }
}
