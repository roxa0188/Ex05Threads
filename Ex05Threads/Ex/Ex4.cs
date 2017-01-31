using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Ex05Threads
{
    class Ex4
    {
        private int alarm = 0;
        Random rnd = new Random();

        public void Run()
        {
            while (alarm < 3)
            {
                int temp = rnd.Next(0, 140) - 20;
                Console.WriteLine(temp);

                if (temp < 0 || temp > 100)
                {
                    Console.WriteLine("Temperature out of range");
                    alarm++;
                }

                Thread.Sleep(2000);
            }

        }
    }
}
