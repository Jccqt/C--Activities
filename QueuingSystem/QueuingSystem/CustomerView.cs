using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QueuingSystem
{
    public partial class CustomerView : Form
    {
        CashierWindowQueueForm cashierWindowQueuePage = new CashierWindowQueueForm();
        public CustomerView()
        {
            InitializeComponent();
        }

        private void CustomerView_Load(object sender, EventArgs e)
        {
            lblQueue.Text = cashierWindowQueuePage.studentInQueue;
        }
    }
}
