using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToolShop_DLL.BL;

namespace ToolShop_DLL.DL
{
    public class ToolDL
    {
        public static List<Tool> tools = new List<Tool>();

        public void AddTool(Tool t)
        {
            tools.Add(t);
        }
        public void RemoveTool(Tool t)
        {
            tools.Remove(t);
        }
    }
}
