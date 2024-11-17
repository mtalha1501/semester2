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
    public class CustomerDB
    {
        public static CustomerDB instance;
        private List<Customer> customers = new List<Customer>();
        public static CustomerDB GetInstance()
        { 
            if (instance == null)
            {
                instance = new CustomerDB();
            }
            return instance;
        }


    }
}
