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
            Program program = new Program();
            program.Run();

        }
        private void Run()
        {
            bool running = true;
            while(running)
            {
                Console.Clear();
                Console.WriteLine("1. Ex2 + 3");
                Console.WriteLine("2. Ex4");
                Console.WriteLine("3. Ex5");
                Console.WriteLine("4. Ex6+7");
                Console.WriteLine("\n0.Exit");

                int Menu = int.Parse(Console.ReadLine());
                Console.Clear();
                switch(Menu)
                    
                {
                    case 0:
                        running = false;
                        break;
                    case 1:
                        ex23();
                        break;
                    case 2:
                        ex4();
                        break;
                    case 3:
                        ex5();
                        break;
                    case 4:
                        ex67();
                        break;


                }

            }


        }

        private void ex23()
        {
            //Ex2 + 3
            Ex23 easy = new Ex23("C# threads is easy!", 5);
            Ex23 multiple = new Ex23("Also, with multiple threads...", 5);
            Thread t1 = new Thread(easy.Run);
            Thread t2 = new Thread(multiple.Run);
            t1.Start();
            t2.Start();
            t1.Join();
            t2.Join();
            Console.WriteLine("\nEnter for Exit!");
            Console.ReadLine();
        }

        private void ex4()
        {
            //Ex4
            Ex4 tmp = new Ex4();
            Thread t3 = new Thread(tmp.Run);
            t3.Start();
            while (t3.IsAlive)
            {
                Thread.Sleep(10000);
            }
            Console.WriteLine("\nAlarm-wire terminated");
            Console.ReadLine();
        }

        private void ex5()
        {
            //Ex5
            Ex5 up = new Ex5(2000, 2);
            Ex5 down = new Ex5(1000, -1);

            Thread t4 = new Thread(up.Run);
            Thread t5 = new Thread(down.Run);

            t4.Start();
            t5.Start();

            Console.ReadLine();
            t4.Abort();
            t5.Abort();
        }

        private void ex67()
        {
            //Ex6+7
            Ex67 star = new Ex67('*');
            Ex67 hash = new Ex67('#');

            Thread t6 = new Thread(star.Run);
            Thread t7 = new Thread(hash.Run);

            t6.Start();
            t7.Start();
            Console.ReadLine();
            t6.Abort();
            t7.Abort();
        }
    }
}
