using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Ex05Threads
{
    class EX6
    {

        public char Char { get; set; }

        static int charCount = 0;
        static object locker = new object();

        public EX6(char c)
        {
            this.Char = c;
            
        }

        public void Run()
        {
            while (true)
            {
                lock (locker)
                {
                    for (int i = 0; i < 60; i++)
                    {
                        Console.Write(this.Char);
                        charCount++;
                    }
                    Console.Write(charCount + "\n");
                    
                }
                Thread.Sleep(500);
            }
        }

    }
}
