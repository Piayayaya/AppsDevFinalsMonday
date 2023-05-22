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
    public partial class AnyaControl1 : UserControl
    {
        public AnyaControl1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Added to Cart");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var parent = this.Parent as Dashboard;
            parent.ItemToOut("Spy x Family Merch: Anya Forger 20 cm Miniature Figure ");
            parent.ItemToOut2("P599.00 ");
            parent.ItemToOut3(numericUpDown1.Value.ToString());
            decimal quantity = numericUpDown1.Value;
            int n = Convert.ToInt32(quantity);
            int price = 599;
            numericUpDown1.Value = quantity;
            int total = n * price;
            parent.ItemToOut4("P" + total.ToString());        
        }

        private void AnyaControl1_Load(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

    }
}
