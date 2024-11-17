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
    public partial class HomePage : KryptonForm
    {
        public HomePage()
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;
        }

        private void HomePage_Load(object sender, EventArgs e)
        {

        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            Login newa = new Login();
            newa.Show();
            Visible = false;
            WindowState = FormWindowState.Maximized;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void gunaButton2_Click(object sender, EventArgs e)
        {
            Form1 newa = new Form1();
            newa.Show();
            Visible = false;
            
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gunaButton3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
