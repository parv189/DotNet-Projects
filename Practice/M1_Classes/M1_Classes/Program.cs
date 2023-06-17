using System
namespace M1_Classes
{
    internal class Program
    {
        int num1;
        int num2;
        int num3;

        void sum()
        {
            num3 = num2 + num1;
            Console.WriteLine(num3);
        }
        void sub()
        {
            num3 = num2 - num1;
            Console.WriteLine(num3);
        }
        static void Main(string[] args)
        {
            Program obj1 = new Program();
            obj1.num1 = 10;
            obj1.num2 = 20; 
            obj1.sum();
            obj1.sub();
            Console.WriteLine("Hello, World!");

            timeinterval t1 = new timeinterval();
            t1._second = 60;
            Console.WriteLine("seconds : {0}",t1._second);
            Console.ReadKey();
        }
    }
    public class timeinterval
    {
        private double second;
            
        public double _second
        {
            get { return second; }
            set { second = value; }
        }
    }
}