using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Ex05Threads
{
    public class Ex23
    {
        public string Text { get; set; }
        public int Count { get; set; }

        public Ex23(string text, int count)
        {
            this.Text = text;
            this.Count = count;
        }

        public void Run()
        {
            for(int i = 0; i<this.Count;i++)
            {
                Console.WriteLine(this.Text);
                Thread.Sleep(1000);
            }
        }
    }
}
