using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace frmTrackThread
{
    internal class MyThreadClass
    {
        public static void Thread1()
        {
            
            for (int i = 0; i <= 2; i++)
            {
                Thread thread = Thread.CurrentThread;
                Console.WriteLine($"Name of Thread: {thread.Name} = {i}");
                Thread.Sleep(500); // will suspend the thread for 0.5 seconds
            }
        }

        public static void Thread2()
        {
            for(int i = 0; i < 6; i++)
            {
                Thread thread = Thread.CurrentThread;
                Console.WriteLine($"Name of Thread: {thread.Name} = {i}");
                Thread.Sleep(1500); // will suspend the thread for 1.5 seconds
            }
            
        }
    }
}
