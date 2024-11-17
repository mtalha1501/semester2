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
    public partial class UserReviews : KryptonForm
    {
        public UserReviews()
        {
            InitializeComponent();
            gunaRadioButton1.Checked = true;
        }

        private void UserReviews_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }
    }
}
