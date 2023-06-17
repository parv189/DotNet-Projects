using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace collections
{
    internal class Program
    {
        public string name { get; set; }
        public int age { get; set; }

        public Program(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public void isEligible()
        {
            if(this.age > 21)
            {
                Console.WriteLine($"{this.name} is eligable");
            }
            else
            {
                Console.WriteLine($"{this.name} is not eligable");
            }
        }

        static void Main(string[] args)
        {
            List<Program> list = new List<Program>();
            Dictionary<string, int> dictionary = new Dictionary<string, int>();
            int i = 0;
            while (i<3)
            {
            Console.WriteLine("Enter Name:");
            string name = Console.ReadLine();
            Console.WriteLine("Enter Age:");
            int age = Convert.ToInt32(Console.ReadLine());
            //list.Add(new Program(name,age));
            dictionary.Add(name, age);
                    i++;
            }
            //list.ForEach(x => Console.WriteLine("{0}{1}",x.name,x.age));
            int j = 0;
            for(j =  0; j < 3; j++)
            {

            Console.WriteLine("{0}{1}", dictionary.Keys.ElementAt(j), dictionary[dictionary.Keys.ElementAt(j)]);
            }
            
            Console.ReadKey();
        }
    }
}
