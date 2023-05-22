using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppsDevProjectFinals
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        public void ItemToOut(string passedValue)
        {
            CheckOutControl1 cout = this.checkOutControl11;
            cout.setLabel6Value(passedValue);
            cout.Show();
            anyaControl11.Hide();
            cout.BringToFront();
        }

        public void Receipt()
        {
            ReceiptControl1 receipt = this.receiptControl11;
            receiptControl11.Show();
            receiptControl11.BringToFront();
        }

        public void CloseReceipt()
        {
            ReceiptControl1 closeRec = this.receiptControl11;
            receiptControl11.Hide();
        }

        public void ItemToOut2(string passedValue)
        {
            CheckOutControl1 cout = this.checkOutControl11;
            cout.setLabel7Value(passedValue);
        }

        public void ItemToOut3(string passedValue)
        {
            CheckOutControl1 cout = this.checkOutControl11;
            cout.setLabel8Value(passedValue);
        }

        public void ItemToOut4(string passedValue)
        {
            CheckOutControl1 cout = this.checkOutControl11;
            cout.setLabel9Value(passedValue);
        }

        private void linkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            anyaControl11.Hide();
            checkOutControl11.Hide();
            receiptControl11.Hide();
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            anyaControl11.Show();
            anyaControl11.BringToFront();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            anyaControl11.Hide();
            checkOutControl11.Hide();
            receiptControl11.Hide();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            anyaControl11.Hide();
            checkOutControl11.Hide();
            receiptControl11.Hide();
        }
    }
}
