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
using ToolShop_DLL.BL;

namespace MyApp.Forms
{
    public partial class UpdateTool : KryptonForm
    {
        public UpdateTool()
        {
            InitializeComponent();
        }

        private void UpdateTool_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            PrintTools();
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void backHomeButton_Click(object sender, EventArgs e)
        {
            AdminToolsMenu newa = new AdminToolsMenu();
            newa.Show();
            Visible = false;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
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

        private void gunaDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void gunaButton4_Click(object sender, EventArgs e)
        {
            string name = usernameBox.Text;
            if (!string.IsNullOrEmpty(name))
            {
                if (Object_Handler.Get_Tool().IsToolPresent(name))
                {
                    Tool tool = Object_Handler.Get_Tool().FindToolByName(name);
                    if (tool != null)
                    {
                        DataTable dataTable = new DataTable();
                        dataTable.Columns.Add("ToolName", typeof(String));
                        dataTable.Columns.Add("ToolPrice", typeof(double));
                        dataTable.Columns.Add("ToolQuantity", typeof(double));
                        gunaDataGridView1.DataSource = dataTable;
                        dataTable.Rows.Add($"{tool.GetToolName()},{tool.GetToolPrice()},{tool.GetQuantity()}");
                        gunaDataGridView1.DataSource = dataTable;
                        
                    }
                }
                else
                {
                    MessageUi.Error("Tool Does Not Exists");
                }
            }

            PrintTools();
        }

        private void gunaButton1_Click(object sender, EventArgs e,string name)
        {
            
            int price = int.Parse(gunaTextBox1.Text);
            int quantity = int.Parse(gunaTextBox2.Text);
            if(price >= 0 && quantity >= 0) 
            {
                Object_Handler.Get_Tool().UpdateTool(price,quantity,name);
            }
            else
            {
                MessageUi.Error("Invalid Values");
            }
            
        }
    }
}
