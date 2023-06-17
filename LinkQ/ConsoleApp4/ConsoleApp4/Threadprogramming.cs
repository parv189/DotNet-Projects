using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Threadprogramming
    {
        public void display()
        {
            for (int i = 0; i < 100; i++)
            {if(Thread.CurrentThread.Name=="Thread1")
                Thread.Sleep(3000);
                Console.WriteLine(Thread.CurrentThread.Name);
            }
        }

        class testinfo
        {
            static void Main(string[] args)
            {
                Threadprogramming threadprogramming = new Threadprogramming();
                ThreadStart threadStart = new ThreadStart(threadprogramming.display);
                Thread thread = new Thread(threadStart);
                thread.Name = "Thread1";
                thread.Start();
                ThreadStart threadStart1 = new ThreadStart(threadprogramming.display);
                Thread thread1 = new Thread(threadStart);
                
                thread1.Name = "Thread2";
                thread1.Start();
                Console.ReadLine();
            }
        }
    }
}
