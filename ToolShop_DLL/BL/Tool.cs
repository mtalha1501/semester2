using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToolShop_DLL.BL
{
    public class Tool
    {
        private int ToolId;
        private string Name;
        private string Description;
        private int Price;
        private int Quantity;

        public Tool(int toolId, string name, string description, int price, int quantity)        {
            ToolId = toolId;
            Name = name;
            Description = description;
            Price = price;
            Quantity = quantity;
        }


        public Tool(string name, string description, int price, int quantity)

        {
            Name = name;
            Description = description;
            Price = price;
            Quantity = quantity;
        }
        public int GetToolId()
        {
            return ToolId;
        }
        public void SetToolId(int id)
        {
            this.ToolId = id;
        }
        public int GetToolPrice()
        {
            return Price;
        }
        public void SetToolPrice(int price)
        {
            this.Price = price;
        }
        public string GetToolName()
        {
            return Name;
        }
        public void SetToolName(string name)
        {
            this.Name= name;
        }
        public string GetToolDescription()
        {
            return Description;
        }
        public void SetToolDescription(string description)
        {
            this.Description= description;
        }
        public int GetQuantity() 
        {
            return Quantity;
        }

        public void SetToolQuantity(int qa)
        {
            this.Quantity += qa;
        }
        public void EditTool(string name,string desc,int price,int quant)
        {
            SetToolDescription(desc);
            SetToolName(name);
            SetToolPrice(price);
            SetToolQuantity(quant);

        }
    }
}
