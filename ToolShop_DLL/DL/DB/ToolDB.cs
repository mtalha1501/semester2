using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToolShop_DLL.Interfaces;
using ToolShop_DLL.BL;
using System.Data.SqlClient;

namespace ToolShop_DLL.DL.DB
{
    public class ToolDB:I_Tool
    {
        private List<Tool> tools = new List<Tool>();
        private static ToolDB instance;
        public static ToolDB GetInstance()
        {
            if (instance == null)
            {
                instance = new ToolDB();
            }
            return instance;
        }
        public List<Tool> GetAllTools()
        {
            return tools;
        }  
        public void AddTool(Tool t)
        {
            tools.Add(t);
        }
        public void RemoveTool(Tool t)
        {
            tools.Remove(t);
        }
        public void DeleteSpecificTool(string name)
        {
            foreach (Tool tl in tools)
            {
                if (tl.GetToolName() == name)
                {
                    tools.Remove(tl);
                    break;
                }
            }
            //EditDeleteProduct(name);
        }
        public void EditDeleteProduct(string name)
        {
            string query = $"DELETE FROM Products WHERE Name='{name}'";
            //SqlCommand cmd = new SqlCommand(query, DB.GetConnection());
            //cmd.ExecuteNonQuery();
        }
        public Tool FindTool(Tool u)
        {
            foreach (Tool stored in tools)
            {
                if (u.GetToolName() == stored.GetToolName())
                { return stored; }
            }
            return null;
        }
        public bool IsToolPresent(string name)
        {
            foreach (Tool tl in tools)
            {
                if (tl.GetToolName() == name)
                    return true;
            }
            return false;
        }
        public bool IsQuantityAvailalbe(string name,int quantity)
        {
            foreach (Tool tl in tools)
            {
                if (tl.GetToolName() == name && tl.GetQuantity() >= quantity)
                    return true;
            }
            return false;
        }
        public Tool FindToolByName(string name)
        {
            foreach(Tool tl in tools)
            {
                if (tl.GetToolName() == name)
                {
                    return tl;
                }
            }
            return null;
        }
        public void UpdateTool(int price,int quantity,string name)
        {
            Tool t = FindToolByName(name);
            t.SetToolPrice(price);
            t.SetToolQuantity(quantity);
        }
    }
}
