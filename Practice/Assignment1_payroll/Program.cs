using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1_payroll
{
    internal class Program
    {
        public class Employee
        {
            public int Id { get; set; } 
            public string Name { get; set; }

            public int leave
            {
                get { return noOfleave; }
                set { noOfleave = value; }
            }

            private int basicSalary = 10000;
            private int noOfleave;

            public Employee(int id, string name, int leave)
            {
                Id = id;
                Name = name;
                this.leave = leave;
            }

            public double calSalary()
            {
                int basic = basicSalary;
                int epf = basic - (12 * basicSalary / 100);

                int inhandsalary = basicSalary - epf - leave/basic;

                return inhandsalary;
                
            }

        }
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>();

            

        }
    }
}
