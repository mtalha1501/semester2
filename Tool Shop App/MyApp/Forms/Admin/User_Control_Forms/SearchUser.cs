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

namespace MyApp.Forms
{
    public partial class SearchUser : KryptonForm
    {
        public SearchUser()
        {
            InitializeComponent();
        }

        private void SearchUser_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
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

        private void gunaButton4_Click(object sender, EventArgs e)
        {

        }
    }
}
