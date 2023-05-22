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
    public partial class CheckOutControl1 : UserControl
    {
        public CheckOutControl1()
        {
            InitializeComponent();
        }

        public void setLabel6Value(string valuePassed)
        {
            label6.Text = valuePassed;
            
        }

        public void setLabel7Value(string valuePassed)
        {
            label7.Text = valuePassed;

        }

        public void setLabel8Value(string valuePassed)
        {
            label8.Text = valuePassed;

        }

        public void setLabel9Value(string valuePassed)
        {
            label9.Text = valuePassed;

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var parent = this.Parent as Dashboard;
            parent.Receipt();
        }

        private void CheckOutControl1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
