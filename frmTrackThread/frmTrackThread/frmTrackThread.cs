using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace frmTrackThread
{
    public partial class frmTrackThread : Form
    {
        private Thread threadA, threadB, threadC, threadD;
        public frmTrackThread()
        {
            InitializeComponent();
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            Console.WriteLine("-Thread Starts-");
            threadA = new Thread(new ThreadStart(MyThreadClass.Thread1));
            threadB = new Thread(new ThreadStart(MyThreadClass.Thread2));
            threadC = new Thread(new ThreadStart(MyThreadClass.Thread1));
            threadD = new Thread(new ThreadStart(MyThreadClass.Thread2));

            // will set the priority of the thread
            threadA.Priority = ThreadPriority.Highest;
            threadB.Priority = ThreadPriority.Normal;
            threadC.Priority = ThreadPriority.AboveNormal;
            threadD.Priority = ThreadPriority.BelowNormal;

            // will set the name of the thread
            threadA.Name = "Thread A";
            threadB.Name = "Thread B";
            threadC.Name = "Thread C";
            threadD.Name = "Thread D";

            threadA.Start();
            threadC.Start();
            threadB.Start();
            threadD.Start();

            threadA.Join();
            threadC.Join();
            threadB.Join();
            threadD.Join();

            Console.WriteLine("-End of Thread-");
        }
    }
}
