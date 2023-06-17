using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Genericdemo<T>
    {
        // T a;
        public void display(T b)
        {
            Console.WriteLine(b);
        }
    }
    class information
    { 
        public static void Main(string[] args)
        {
            var genericdemo = new Genericdemo<string>();
            genericdemo.display("abcd");
            var genericdemo1 = new Genericdemo<int>();
            genericdemo1.display(12);
            Console.ReadLine();
        }
    }
}

