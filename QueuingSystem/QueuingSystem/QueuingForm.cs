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
    public partial class QueuingForm : Form
    {
        private CashierClass cashier;
        CashierWindowQueueForm cashierWindowPage = new CashierWindowQueueForm();
        Timer timer = new Timer();
        public QueuingForm()
        {
            InitializeComponent();

            cashier = new CashierClass();
            cashierWindowPage.Show();

            timer.Interval = (5 * 1000); // 5 seconds

            // will invoke the btnRefresh_Click event every tick of the timer
            timer.Tick += new EventHandler(cashierWindowPage.btnRefresh_Click);
            timer.Start();
        }

        private void btnCashier_Click(object sender, EventArgs e)
        {
            lblQueue.Text = cashier.CashierGeneratedNumber("P - ");
            CashierClass.getNumberInQueue = lblQueue.Text;

            // will add the generated cashier number to the queue
            CashierClass.CashierQueue.Enqueue(CashierClass.getNumberInQueue);
        }
    }
}
