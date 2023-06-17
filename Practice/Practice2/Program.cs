using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice2
{
    internal class Program
    {

        public class BankAccount
        {       
            public static int accountNumberSeed = 1067000;
            public string Number { get; }
            public string Owner { get; set; }
            public decimal Balance
            {
                get
                {
                    decimal balance = 0;
                    foreach(var item in allTransactions)
                    {
                        balance += item.Amount;
                    }
                    return balance;
                }
                set
                {
                    if(value == 0)
                    {
                    Balance = value;

                    }
                }
            }
            public BankAccount(string name, decimal initialBalance)
            {
                Owner = name;
                Balance = initialBalance;
                Number = accountNumberSeed.ToString();
                accountNumberSeed++;
         
                MakeDeposit(initialBalance, DateTime.Now, "Initial balance");
            }
            private List<Transaction> allTransactions = new List<Transaction>();
            

            public void MakeDeposit(decimal amount, DateTime date, string note)
            {
                if (amount <= 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(amount), "Amount of deposit must be positive");
                }
                var deposit = new Transaction(amount, date, note);
                allTransactions.Add(deposit);
                //Console.WriteLine(deposit.Amount);
            }

            public void MakeWithdrawal(decimal amount, DateTime date, string note)
            {
                if (amount <= 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(amount), "Amount of withdrawal must be positive");
                }
                if (Balance - amount < 0)
                {
                    throw new InvalidOperationException("Not sufficient funds for this withdrawal");
                }
                var withdrawal = new Transaction(-amount, date, note);
                allTransactions.Add(withdrawal);
            }
            public void Display()
            {
                Console.WriteLine("name:\t" + Owner);
                Console.WriteLine("Balance:\t"+Balance);
                Console.WriteLine("Number:\t" + Number);

            }

        }
        public class Transaction
        {
            public decimal Amount { get; }
            public DateTime Date { get; }
            public string Notes { get; }

            public Transaction(decimal amount, DateTime date, string note)
            {
                Amount = amount;
                Date = date;
                Notes = note;
            }
        }
        static void Main(string[] args)
        {
            int i = 0;
           // var account = new BankAccount("<name>", 1000);
            var account = new BankAccount("parv",1000);
            //for(i=0;i<5; i++)
            //{
            //    account.Add(new BankAccount("person"+(i+1), 1000));
            //    account[i].Display();
            //}
            Console.WriteLine($"Account {account.Number} was created for {account.Owner} with {account.Balance} initial balance.");
            account.MakeWithdrawal(500, DateTime.Now, "Rent payment");
            Console.WriteLine(account.Balance);
            account.MakeDeposit(100, DateTime.Now, "Friend paid me back");
            Console.WriteLine(account.Balance);
            Console.ReadKey();
        }
    }
}
