using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
           // int a = 10;
           // int b = 100;
           // int add = a + b;
           //  int sub = a - b;
           // int mul = a * b;
           // int div = a / b;
           //int mod = a % b;
           // Console.WriteLine(add);       
           // Console.WriteLine(sub);       
           // Console.WriteLine(mul);       
           // Console.WriteLine(div);       
           // Console.WriteLine(mod);       
           // Console.ReadKey();

           int num1 = 0, num2 = 0;

            Console.WriteLine("colsole calculator in C#");
            Console.WriteLine("------------------------ \n");

            Console.WriteLine("Write a number and then press enter");
             num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Write an another number and press enter");
             num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Choose an option from the following list:");
            Console.WriteLine("\ta - Add");
            Console.WriteLine("\ts - Subtract");
            Console.WriteLine("\tm - Multiply");
            Console.WriteLine("\td - Divide");
            Console.Write("Your option? ");
            

            switch (Console.ReadLine())
            {
                case "a":
                    Console.WriteLine("your result is: "+ (num1 + num2));
                    break;
                case "s":
                    Console.WriteLine($"{num1} minus {num2} is: "+(num1 - num2));
                    break;
                case "m":
                    Console.WriteLine("your result is: {0}",(num1 * num2));
                    break;
                case "d":
                    Console.WriteLine("your result is:{0} ", num1 / num2);
                    break;

            }
            Console.WriteLine("press any key to close console");
            Console.ReadKey();


        }
    }
}
