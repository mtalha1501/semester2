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
using ToolShop_DLL.DL;

namespace MyApp.Forms
{
    public partial class DeleteUser : KryptonForm
    {
        public DeleteUser()
        {
            InitializeComponent();
        }

        private void DeleteUser_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            //Display_users_In_Grid();
        }
        private void Remove_User(User u)
        {
            
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

        private void gunaButton5_Click(object sender, EventArgs e)
        {
            DeleteUser newa = new DeleteUser();
            newa.Show();
            Visible = false;
        }

        private void PrintProducts()
        {

            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("User Name", typeof(String));
            dataTable.Columns.Add("Password", typeof(String));
            dataTable.Columns.Add("Role", typeof(String));
            dataTable.Columns.Add("Phone No", typeof(String));
            gunaDataGridView1.DataSource = dataTable;
            List<User> user = Object_Handler.Get_User().GetUsers();

            if (user != null && user.Count > 0)
            {
                foreach (User pr in user)
                {
                    dataTable.Rows.Add(pr.GetUsername(), pr.GetPassword(),pr.GetRole(),pr.GetPhone());

                }
            }
            gunaDataGridView1.DataSource = dataTable;
        }
        private void ManageUsers_Load(object sender, EventArgs e)
        {
            // Define DataGridView columns
            gunaDataGridView1.ColumnCount = 4; // Assuming 6 columns for UsernameName, Password, Role, Phone #

            // Set column headers
            gunaDataGridView1.Columns[0].Name = "UserName";
            gunaDataGridView1.Columns[1].Name = "Password";
            gunaDataGridView1.Columns[2].Name = "Role";
            gunaDataGridView1.Columns[3].Name = "Phone";
            

            // Auto-size columns mode
            gunaDataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
    }
}
