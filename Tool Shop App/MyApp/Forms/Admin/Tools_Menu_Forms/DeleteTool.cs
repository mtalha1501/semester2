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
using Guna.UI.WinForms;
using ToolShop_DLL.BL;
using ToolShop_DLL.DL;
using ToolShop_DLL.Interfaces;

namespace MyApp.Forms
{
    public partial class DeleteTool : KryptonForm
    {
        public DeleteTool()
        {
            InitializeComponent();
        }

        private void DeleteTool_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            PrintTools();
        }

        private void gunaButton4_Click(object sender, EventArgs e)
        {

        }
        private void Remove_Tool(string name, string desc, int price, int quan)
        {
            Tool t = new Tool(name, desc, price, quan);
            ToolDL.tools.Remove(t);
        }

        private void gunaButton5_Click(object sender, EventArgs e)
        {
            DeleteUser newa = new DeleteUser();
            newa.Show();
            Visible = false;
        }

        private void gunaButton3_Click(object sender, EventArgs e)
        {
            SearchUser newa = new SearchUser();
            newa.Show();
            Visible = false;
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            ShowAllUsers newa = new ShowAllUsers();
            newa.Show();
            Visible = false;
        }
        private void Display_users_In_Grid()
        {
            List<UserDL> users = new List<UserDL>();



        }

        private void gunaDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ToolPrice_TextChanged(object sender, EventArgs e)
        { } 
        private void Search()
        {

        }
        private void PrintTools()
        {
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("Tool Name", typeof(String));
            dataTable.Columns.Add("Price", typeof(int));
            dataTable.Columns.Add("Quantity", typeof(int));
            dataTable.Columns.Add("Description", typeof(String));
            gunaDataGridView1.DataSource = dataTable;
            List<Tool> tools = Object_Handler.Get_Tool().GetAllTools();

            if (tools != null && tools.Count > 0)
            {
                foreach (Tool t in tools)
                {
                    dataTable.Rows.Add(t.GetToolName(), t.GetToolPrice(), t.GetQuantity(), t.GetToolDescription());
                }
            }
            gunaDataGridView1.DataSource = dataTable;
        }
        private void Clear()
        {
            ToolPrice.Text = "";
        }

        private void gunaButton7_Click(object sender, EventArgs e)
        {
            string name = ToolPrice.Text;
            if (!string.IsNullOrEmpty(name))
            {
                if (Object_Handler.Get_Tool().IsToolPresent(name))
                {
                    Object_Handler.Get_Tool().DeleteSpecificTool(name);
                    MessageUi.ShowMessage("Congratulations", "Tool Deleted Successfully");
                }
                else
                {
                    MessageUi.Error("Tool Does Not Exists");
                }
            }

            PrintTools();
        }
    }
}
