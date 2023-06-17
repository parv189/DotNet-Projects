using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace ConsoleApp4
{
    
    class test :ICloneable
    {
        int a,b;
        test()
        {

        }
        public test(int a,int b)
        {
            this.a= a;
          this.b = b;
        }

        public int A { get => a; set => a = value; }
        public int B { get => b; set => b = value; }

        public  test add(test t,test t1)
        {
            test result = new test();
            result.a = t.a + t1.a;
            result.b = t.b + t1.b;
            return result;
        }
        public void display()
        {
            Console.WriteLine(A);
            Console.WriteLine(B);
        }
        public override bool Equals(object obj)
        {
            test t = (test)obj;
            if (a == t.a && b == t.b)
            {
                return true;
            }
            else
            {
                return false;
                    }
        }

        public Object Clone()
        {
            return this.MemberwiseClone();
        }
        public override string ToString()
        {
            return $" A is {a} B is {b}";
        }
    }
    class employee
    {
        public int sum(int a,int b)
        {
            return a + b;
        }
        public int sum(int a,int b, int c)
        {
            return a + b + c;
        }
        public float sum(float c,float d)
        {
            return c + d;
        }
        public int sum(int[] a)
        {
            int sum = 0;
            foreach (var item in a)
            {
                sum += item;
            }
            return sum;
        }
        public float sum(params float[] a)
        {
            float sum = 0;
            foreach (var item in a)
            {
                sum += item;
            }
            return sum;
        }
    }
    class emp
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public void xyz()
        {
            Console.WriteLine("parent");
        }
     //   public abstract void salary();
            public virtual void salary()
        {
            Console.WriteLine("diwali bonus");
        }

       
    }
    class PartTime : emp
    {
        public new void xyz()
        {
            Console.WriteLine("hello");
        }
        public override void salary()
        {
            base.salary();
            Console.WriteLine("PArt time salary");
           // throw new NotImplementedException();
        }
        public void abc()
        {
            Console.WriteLine(Name);
        }
        public override string ToString()
        {
            return $"ID is {ID} Name is {Name} Address is {Address}";
        }
    }
    class Fulltime : emp
    {
        public override void salary()
        {
            base.salary();
            Console.WriteLine("Full time salary");
          //  throw new NotImplementedException();
        }
    }
    internal class Program
    {
        public static void info(emp emp)
        {
            emp.xyz();
            Console.WriteLine(emp);
            Console.WriteLine(emp.GetType().Name);
            if(emp.GetType().Name=="PartTime")
            {
                PartTime partTime = (PartTime)emp;
              //  Console.WriteLine(partTime.ToString());
                partTime.xyz();
                partTime.abc();
            }
            emp.salary();
            
           // Console.WriteLine(e);
        }
        static void Main(string[] args)
        {
            ArrayList arrayList = new ArrayList() { 12, 45, 66, 66,"dfgd","sdf",new PartTime() { ID = 1, Name = "teena", Address = "mumbai" } };
            foreach (var item in arrayList)
            {
                Console.WriteLine(item);
            }
            Stack stack = new Stack();
            stack.Push(12);
            stack.Push("dsfsd");
            stack.Push(new PartTime() { ID = 1, Name = "A", Address = "ahmedabad" });
            Console.WriteLine(stack);
            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(stack.Pop());
            IEnumerator enumerator = stack.GetEnumerator();
            while(enumerator.MoveNext())
            {
                Console.WriteLine(enumerator.Current);
            }
            Hashtable hashtable = new Hashtable();
            hashtable.Add(1, "Pen");
            hashtable.Add(2, "Pencil");
            Console.WriteLine("Enter product id");
            int id = Convert.ToInt32(Console.ReadLine());
           if( hashtable.ContainsKey(id))
            {
                Console.WriteLine(hashtable[id]);
            }
           else
            {
                Console.WriteLine("Record not found");
            }

            Console.WriteLine("Enter 1 for part time");
            Console.WriteLine("Enter 2 for full time");
            int choice = Convert.ToInt32(Console.ReadLine());
            emp e = null;
            switch(choice)
            {
                case 1:e = new PartTime() { ID = 1, Name = "abc", Address = "xyz" };
                    Program.info(e);
                    break;
                case 2:e = new Fulltime();
                    Program.info(e);
                    break;
                default: Console.WriteLine("Invalid choice");
                    break;
            }
            //   e.salary();
            Console.WriteLine("___________clone");
            test test = new test(12, 56);
         var abc= test.Clone();
            Console.WriteLine(abc);
            test.A = 888;
            Console.WriteLine(test);
            Console.WriteLine(abc);
            Console.WriteLine("___________clone");
            test testinfo = new test(121, 56);
            Console.WriteLine(test.Equals(testinfo));
          
            // test res = test.add(test,testinfo);
            // res.display();
            // test test1 = test;
            // test.A = 90;
            // test.B = 88;
            // test.display();
            // test1.display();
            // System.Drawing.Size size = new System.Drawing.Size(12,45);
            // System.Drawing.Size size1 = new System.Drawing.Size(45, 56);
            // System.Drawing.Size size2 = size + size1;
            // Console.WriteLine(size2);

            // var emp = new employee();
            // int[] ar = { 123, 5, 6, 6 };
            // Console.WriteLine(emp.sum(ar));
            // Console.WriteLine( emp.sum(12, 45, 5, 67, 77, 77));
            //// emp.sum(12.5f,45.5f)
            // Console.BackgroundColor = ConsoleColor.DarkGreen;
            // Console.WriteLine("Hello world");
            Console.ReadLine();
        }
    }
}
