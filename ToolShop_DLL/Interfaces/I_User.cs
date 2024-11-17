using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToolShop_DLL.BL;
using ToolShop_DLL.DL.DB;

namespace ToolShop_DLL.Interfaces
{
    public interface I_User
    {
        List<User> GetUsers();

    }
}
