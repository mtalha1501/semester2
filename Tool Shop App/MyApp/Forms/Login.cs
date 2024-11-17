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
using ToolShop_DLL.DL; 

namespace MyApp.Forms
{
    public partial class Login : KryptonForm
    {
        public Login()
        {
            InitializeComponent();
            //WindowState = FormWindowState.Maximized;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void passwordlogin_TextChanged(object sender, EventArgs e)
        {

        }

        private void gunaImageButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void gunaImageButton2_Click(object sender, EventArgs e)
        {
                  
        }

        private void Login_Load(object sender, EventArgs e)
        {
            //WindowState = FormWindowState.Maximized;
        }

        private void gunaLinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 newa = new Form1();
            newa.Show();
            Visible = false;
            //newa.WindowState = FormWindowState.Maximized;
        }

        private void gunaPictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void backHomeButton_Click(object sender, EventArgs e)
        {
            HomePage newa = new HomePage();
            newa.Show();
            Visible = false;
            WindowState = FormWindowState.Maximized;
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            string username = usernameBox.Text;
            string password = gunaTextBox2.Text;
            if(username == "" || password == "")
            {
                MessageBox.Show("Username or password must not be empty");
                return;
            }

            if (UserDL.CheckUser(username,password))
            {
                if (UserDL.CheckCustomer(username))
                {
                    Load_Customer(sender,e);
                }
                else
                {
                    Load_Manager(sender,e);
                }
            }
            else
            {
                MessageBox.Show("User Do not Exists");
                return;
            }

        }
        private void Load_Customer(object sender, EventArgs e)
        {
            UserHomePage newa = new UserHomePage();
            newa.Show();
            Visible =false;
        }
        private void Load_Manager(object sender, EventArgs e)
        {
            AdminHomePage newa = new AdminHomePage();
            newa.Show();
            Visible = false;
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
