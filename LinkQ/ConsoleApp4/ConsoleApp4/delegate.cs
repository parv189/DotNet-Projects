using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    static class demo
    {
        public static int vowelcount(this string s)
        {
            int count = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == 'a' || s[i]=='e')
                {
                    count++;
                }
            }
            return count;
        }
    }

    internal class @delegate
    {
      
public        void display()
        {
            Console.WriteLine("Hello world");
        }
        public int add(int x,int y)
        {
            return x + y;
        }
    }
    class test1
    {
        delegate void mydelegate();
        public static void Main(string[] args)
        {
            @delegate @delegate = new @delegate();
            mydelegate mydelegate = new mydelegate(@delegate.display);
            mydelegate();
            mydelegate();
            Func<int, int, int> func = new Func<int, int, int>(@delegate.add);
           Func<int,int,int> func1 = new Func<int, int, int>((a, b) => { return a - b; });
            Console.WriteLine(func(12, 5));
            Console.WriteLine(func1(45,5));
            string s = "apple";
            Console.WriteLine(s.vowelcount());
            Console.ReadLine();
            //Delegate mydelegate = new Delegate(@delegate.display);
        }
    }

}
