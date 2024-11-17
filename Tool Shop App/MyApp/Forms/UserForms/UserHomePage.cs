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
    public partial class UserHomePage : KryptonForm
    {
        public UserHomePage()
        {
            InitializeComponent();
        }

        private void UserHomePage_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void gunaLabel2_Click(object sender, EventArgs e)
        {

        }

        private void gunaButton7_Click(object sender, EventArgs e)
        {
            HomePage newa = new HomePage();
            newa.Show();
            Visible = false;
        }
    }
}
