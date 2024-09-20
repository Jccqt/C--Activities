using System;
using System.Collections;
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
    public partial class CashierWindowQueueForm : Form
    {
        CustomerView customerViewPage = new CustomerView();
        public string studentInQueue = "";
        public CashierWindowQueueForm()
        {
            InitializeComponent();
        }

        public void btnRefresh_Click(object sender, EventArgs e)
        {
            DisplayCashierQueue(CashierClass.CashierQueue);
        }

        public void DisplayCashierQueue(IEnumerable CashierList)
        {
            listCashierQueue.Items.Clear();
            foreach(Object obj in CashierList)
            {
                listCashierQueue.Items.Add(obj.ToString());
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            
            if(CashierClass.CashierQueue.Count != 0)
            {
                studentInQueue = CashierClass.CashierQueue.Peek().ToString();
                // will remove the first item in the queue
                CashierClass.CashierQueue.Dequeue();

                // will refresh the cashier queue list
                DisplayCashierQueue(CashierClass.CashierQueue);
                customerViewPage.Show();
            }
            else
            {
                MessageBox.Show("There is no currently in queue");
            }
            
        }
    }
}
