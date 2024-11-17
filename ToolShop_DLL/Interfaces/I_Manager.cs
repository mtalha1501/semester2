using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToolShop_DLL.DL;
using ToolShop_DLL.BL;

namespace ToolShop_DLL.Interfaces
{
    public interface I_Manager
    {
        List<Manager> GetManagers();
        void RemoveUser(User u);
        void AddUser(User u);
        User FindUser(User u);
    }
}
