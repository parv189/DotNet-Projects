using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M2_classes
{
    internal class Program
    {
        private double second ;
        public double sec
        {
            get { return second ; }
            set
            {
                if (value > 0 && value < 100)
                {
                    second = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException(nameof(value));
                }
            }
        }

        
    }
    public class hours
    {
        static void Main(string[] args)
        {
            Program t1 = new Program();
            t1.sec = 10;
            Console.WriteLine(t1.sec);
            Console.ReadLine();

        }
    }
}
