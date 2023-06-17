using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oops
{ 
    //inheritance
    public abstract class Animals
    {
        private string identity;//encapsulation
        public string Name { get; set; }
        public decimal weight { get; set; }
        public decimal height { get; set; }

        public string ID
        {
            get {return identity; }
            set { identity = value; }
        }

        public Animals(string name,decimal weight)
        {
            Name = name;
            this.weight = weight;
            ID = name+weight;
        }
        public abstract string mainaction();//abstraction

        public virtual string sound()//polymorphism
        {
            Console.WriteLine("{0}",GetType().Name);
            return "";
        }
    }
    public class cheeta : Animals
    {
        public cheeta(string a,decimal b) : base(a,b)
        {

        }
        public override string mainaction()
        {
            return "running fast";
        }
        public override string sound()
        {
            Console.WriteLine("{0},maaau",GetType().Name);
            return "";
        }
    }
    public class lion : Animals
    {
        public lion(string a, decimal b) : base(a, b)
        {

        }
        public override string mainaction()
        {
           return "roring loud";
        }
        public override string sound()
        {
            Console.WriteLine("{0},roorr", GetType().Name);
            return "";
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Animals[] x = new Animals[]
            {
                new cheeta("bagi",300),new lion("seru",550),
            };

            foreach(Animals animals in x)
            {
                Console.WriteLine("{0}{1}{2}{3}",animals.GetType().Name , animals.mainaction() ,animals.ID,animals.sound());
            }

        }
    }
}
