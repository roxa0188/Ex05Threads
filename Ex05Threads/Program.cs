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
            Thread t1 = new Thread(easy.Run);
            t1.Start();
            t1.Join();
            Console.WriteLine("\nEnter for Exit!");
            Console.ReadLine();



        }
    }
}
