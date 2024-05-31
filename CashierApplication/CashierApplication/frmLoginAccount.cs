using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UserAccountNamespace;

namespace CashierApplication
{
    public partial class frmLoginAccount : Form
    {
        static frmPurchaseDiscountItem DiscountPage = new frmPurchaseDiscountItem();
        public frmLoginAccount()
        {
            InitializeComponent();
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            Cashier cashier = new Cashier("Clarisa Castro", "Finance", UsernameBox.Text, PasswordBox.Text);
            if (cashier.validateLogin(UsernameBox.Text, PasswordBox.Text))
            {
                MessageBox.Show($"Welcome {cashier.getFullName()} of {cashier.getDepartment()}");
                DiscountPage.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid username or password");
            }
        }
    }
}
