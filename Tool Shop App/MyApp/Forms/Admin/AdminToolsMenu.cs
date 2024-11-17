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

namespace MyApp.Forms
{
    public partial class AdminToolsMenu : KryptonForm
    {
        public AdminToolsMenu()
        {
            InitializeComponent();
        }

        private void AdminToolsMenu_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void gunaButton4_Click(object sender, EventArgs e)
        {
            ShowTools newa = new ShowTools();
            newa.Show();
            Visible = false;
        }

        private void gunaButton2_Click(object sender, EventArgs e)
        {
            AdminToolsMenu newa = new AdminToolsMenu();
            newa.Show();
            Visible = false;
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

        private void gunaButton7_Click(object sender, EventArgs e)
        {
            HomePage newa = new HomePage();
            newa.Show();
            Visible = false;
        }

        private void gunaButton8_Click(object sender, EventArgs e)
        {
            AddTool newa = new AddTool();
            newa.Show();
            Visible = false;
        }

        private void gunaButton5_Click(object sender, EventArgs e)
        {
            DeleteUser newa = new DeleteUser();
            newa.Show();
            Visible = false;
        }

        private void gunaButton9_Click(object sender, EventArgs e)
        {
            DeleteTool newa = new DeleteTool();
            newa.Show();
            Visible = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            HomePage newa = new HomePage();
            newa.Show();
            Visible =false;
        }

        private void gunaButton10_Click(object sender, EventArgs e)
        {
            UpdateTool newa = new UpdateTool();
            newa.Show();
            Visible = false;
        }
    }
}
