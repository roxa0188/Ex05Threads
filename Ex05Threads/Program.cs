using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;


namespace Ex05Threads
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Start");

            TextWriter easy = new TextWriter("C# threads is easy!", 5);
            TextWriter multiple = new TextWriter("Also, with multiple threads...", 5);
            Thread t1 = new Thread(easy.Run);
            Thread t2 = new Thread(multiple.Run);
            t1.Start();
            t2.Start();
            t1.Join();
            t2.Join();
            Console.WriteLine("\nEnter for Exit!");
            Console.ReadLine();

            



        }
    }
}
