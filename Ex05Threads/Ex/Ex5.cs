using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Ex05Threads
{
    class Ex5
    {
        public int delay{ get; set; }
        public int count { get; set; }

         static int counter = 0;
         static object locker = new object();

        public Ex5(int delay, int count)
        {
            this.delay = delay;
            this.count = count;
        }

        public void Run()
        {
            while (true)
            {
                string ThreadName = Thread.CurrentThread.Name;
                Console.WriteLine("{0} entered lock", ThreadName);
                Monitor.Enter(locker);
                try
                {
                    counter = counter + count;
                    Console.WriteLine(counter);
                }
                finally
                {
                    Monitor.Exit(locker);
                    Console.WriteLine("{0} released lock", ThreadName);
                }

                Thread.Sleep(delay);
            }

        }

    }
}
