using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ToolShop_DLL.BL;
using ToolShop_DLL.Utilities;
using ComponentFactory.Krypton.Toolkit;
using Guna.UI2.WinForms;
using Guna.UI;

namespace MyApp.Forms
{
    public partial class Purchase_Tool : KryptonForm
    {
        public Purchase_Tool()
        {
            InitializeComponent();
        }
        private void PrintTools()
        {
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("Tool Name", typeof(String));
            dataTable.Columns.Add("Price", typeof(int));
            dataTable.Columns.Add("Quantity", typeof(int));
            dataTable.Columns.Add("Description", typeof(String));
            //gunaDataGridView1.DataSource = dataTable;
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

        private void Purchase_Tool_Load(object sender, EventArgs e)
        {

        }
        private void gunaButton4_Click(object sender, EventArgs e)
        {

        }




    }
    
}
