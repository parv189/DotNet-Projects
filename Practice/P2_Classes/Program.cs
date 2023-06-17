using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace P2_Classes
{
    internal class Bankaccount
    {
        private static int accountNumberSeed = 1234567890;
        public string Number;
        public string Owner;
        public string Balance;


        public Bankaccount(string Name, string initialbalance)
        {
            Owner = Name;
            Balance = initialbalance;
            this.Number = accountNumberSeed.ToString();
            accountNumberSeed++;
        }

        public void Makedeposite(decimal amount, DateTime date, string note)
        {

        }
        public void MakeWithdrawal(decimal amount, DateTime date, string note)
        {

        }
        public void Display()
        {
            Console.WriteLine("Name :{0}", Owner);
            Console.WriteLine("Balance : {0}",Balance);
            Console.WriteLine("Number :{0}", Number);
        }

        public static void Main(string[] args)
        {
            var account = new List<Bankaccount>();
       
            for (int i = 0; i < 10; i++)
            {

                account.Add(new Bankaccount ("Person" + (i + 1), "1000" ));
                account[i].Display();
            }
            //Console.WriteLine(account.Owner + account.Balance + account.Number);
            Console.ReadKey();

        }
    }
}
