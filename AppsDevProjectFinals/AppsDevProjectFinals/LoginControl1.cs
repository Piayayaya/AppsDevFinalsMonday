using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppsDevProjectFinals
{
    public partial class LoginControl1 : UserControl
    {
        public LoginControl1()
        {
            InitializeComponent();
        }

        private void LoginControl1_Load(object sender, EventArgs e)
        {
            regisControl11.Hide();
            forPassControl11.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "pia" && textBox2.Text == "pia") {
                var dash = new Dashboard();
                var form = new Form();
                form.Hide();
                dash.Show();
                
            }
        }

        private void regisControl11_Load(object sender, EventArgs e)
        {

        }
    }
}
