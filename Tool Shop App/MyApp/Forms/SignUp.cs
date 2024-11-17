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
using ToolShop_DLL;
using ToolShop_DLL.BL;
using ToolShop_DLL.DL;

namespace MyApp.Forms
{
    public partial class Form1 : KryptonForm
    {
        public Form1()
        {
            InitializeComponent();
            gunaRadioButton2.Checked = true;
            WindowState = FormWindowState.Maximized;
        }
        
        private void kryptonPalette1_PalettePaint(object sender, ComponentFactory.Krypton.Toolkit.PaletteLayoutEventArgs e)
        {
            
        }
        
        private void LoginButton_Click(object sender, EventArgs e)
        {
            
            string username = usernameBox.Text;
            string password = gunaTextBox2.Text;
            string age = gunaTextBox1.Text;
            string phone = gunaTextBox3.Text;
            if(username == "" || password == "" || age == "" || phone == "")
            {
                MessageBox.Show("All Fields Must be filled");
                return;
            }
            string role = "";
            if (gunaRadioButton1.Checked)
            {
                role = "manager";
                Manager mg = new Manager(username,password,role,age,phone);
                UserDL.users.Add(mg);
                UserDL.managers.Add(mg);
            }
            else if (gunaRadioButton2.Checked)
            {
                role = "Customer";
                Customer cu = new Customer(username, password, role, age, phone);
                UserDL.users.Add(cu);
                UserDL.customers.Add(cu);
            }

            MessageBox.Show("Sign Up Successfully");
            Login newa = new Login();
            newa.Show();
            Visible = false;

        }
        

        private void gunaLinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login newa = new Login();
            newa.Show();
            Visible = false;
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void backHomeButton_Click(object sender, EventArgs e)
        {
            HomePage newa = new HomePage();
            newa.Show();
            Visible = false;
            
        }

        private void usernameBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void gunaTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void gunaTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void gunaTextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void gunaRadioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void gunaRadioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
