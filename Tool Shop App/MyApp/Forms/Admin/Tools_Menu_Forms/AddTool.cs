using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
using ToolShop_DLL.Utilities;
using ToolShop_DLL.DL;
using ToolShop_DLL.BL;
using ToolShop_DLL.Interfaces;
using System.Diagnostics;
using System.Security.Cryptography;

namespace MyApp.Forms
{
    public partial class AddTool : KryptonForm
    {
        public AddTool()
        {
            InitializeComponent();
        }

        private void AddTool_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void usernameBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void gunaButton5_Click(object sender, EventArgs e)
        {
            DeleteUser newa = new DeleteUser();
            newa.Show();
            Visible = false;
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            string Tname = toolname.Text;
            string Tdesc = ToolDescription.Text;
            int TQuantity = int.Parse(toolQuantity.Text);
            int Tprice = int.Parse(ToolPrice.Text);
            if (Validations.CheckNumber(toolQuantity.Text) && Validations.CheckNumber(ToolPrice.Text)&&Tname != null&&Tdesc !=null)
            {
                if (Object_Handler.Get_Tool().IsToolPresent(Tname))
                {
                    MessageUi.Error("Tool is already Present,change the name");
                    return;
                }
                else
                {
                    Add_Tool(Tname, Tdesc, Tprice, TQuantity);
                    MessageBox.Show(Tname + " Added Successfully");
                }
                
            }
            else
            {
                MessageBox.Show("Invalid inputs");
                return;
            }
        }
        private void Add_Tool(string name,string desc,int price,int quan)
        {
            Tool t = new Tool(name, desc, price, quan);
            Object_Handler.Get_Tool().AddTool(t);
        }

        private void gunaButton2_Click(object sender, EventArgs e)
        {
            AdminToolsMenu news = new AdminToolsMenu();
            news.Show();
            Visible = false;
        }
    }
}
