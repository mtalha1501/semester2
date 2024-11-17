using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToolShop_DLL.BL;
using ToolShop_DLL.DL;

namespace ToolShop_DLL.Interfaces
{
    public interface I_Cart
    {
        void AddTool(Tool t);

        void AddToolToCart(Tool tool);

        void RemoveTool(Tool t);

        void ClearCart();

        List<Tool> GetCart();

        bool CheckCart();

        int GetTotalCartAmount();

        
    }
}
