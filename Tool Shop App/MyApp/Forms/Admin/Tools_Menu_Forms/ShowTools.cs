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
using MyApp.Forms;
using ToolShop_DLL.BL;

namespace MyApp.Forms
{
    public partial class ShowTools : KryptonForm
    {
        public ShowTools()
        {
            InitializeComponent();
        }

        private void ShowTools_Load(object sender, EventArgs e)
        {
            PrintTools();
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            ShowAllUsers newa = new ShowAllUsers();
            newa.Show();
            Visible = false;
        }

        private void gunaButton3_Click(object sender, EventArgs e)
        {
            SearchUser newa = new SearchUser();
            newa.Show();
            Visible = false;
        }

        private void gunaButton2_Click(object sender, EventArgs e)
        {
            AdminToolsMenu newa = new AdminToolsMenu();
            newa.Show();
            Visible = false;
        }

        private void gunaButton7_Click(object sender, EventArgs e)
        {
            HomePage newa = new HomePage();
            newa.Show();
            Visible = false;
        }

        private void gunaButton5_Click(object sender, EventArgs e)
        {
            DeleteUser newa = new DeleteUser();
            newa.Show();
            Visible = false;
        }

        private void gunaDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
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
                    dataTable.Rows.Add(t.GetToolName(), t.GetToolPrice(), t.GetQuantity(),t.GetToolDescription());
                }
            }
            gunaDataGridView1.DataSource = dataTable;
        }

        private void gunaDataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
