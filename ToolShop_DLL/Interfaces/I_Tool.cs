using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToolShop_DLL.DL;
using ToolShop_DLL.BL;

namespace ToolShop_DLL.Interfaces
{
    public interface I_Tool
    {
        void AddTool(Tool t);
        void RemoveTool(Tool t);
        List<Tool> GetAllTools();
        Tool FindTool(Tool u);
        bool IsToolPresent(string name);
        Tool FindToolByName(string name);
        void DeleteSpecificTool(string name);
        void UpdateTool(int price, int quantity, string name);
    }
}
