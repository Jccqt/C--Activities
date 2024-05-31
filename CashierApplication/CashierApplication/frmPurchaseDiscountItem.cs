using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ItemNamespace;

namespace CashierApplication
{
    public partial class frmPurchaseDiscountItem : Form
    {
        static DiscountItem Item;
        static frmLoginAccount Login = new frmLoginAccount();
        public frmPurchaseDiscountItem()
        {
            InitializeComponent();
        }

        private void ComputeBtn_Click(object sender, EventArgs e)
        {
            Item = new DiscountItem(NameBox.Text, Convert.ToDouble(PriceBox.Text), Convert.ToInt32(QuantityBox.Text), Convert.ToDouble(DiscountBox.Text));
            AmountLabel.Text = Item.getTotalPrice().ToString();
        }

        private void SubmitBtn_Click(object sender, EventArgs e)
        {
            if(Convert.ToDouble(AmountLabel.Text) <= Convert.ToDouble(PaymentBox.Text))
            {
                Item.setPayment(Convert.ToDouble(PaymentBox.Text));
                ChangeLabel.Text = Item.getChange().ToString();
            }
            else
            {
                MessageBox.Show("Insufficient payment!");
            }
            
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login.Show();
            this.Hide();
        }

        private void exitApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
