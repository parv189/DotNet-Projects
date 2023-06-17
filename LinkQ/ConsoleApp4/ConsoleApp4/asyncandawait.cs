using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class asyncandawait
    {
        public async Task<int> printnumbers()
            {
            int sum = 0;
            await Task.Run(() =>
            {
                for (int i = 0; i < 100; i++)
                {
                    sum += i;
                }
            });
            return sum;
        }

      public  static async Task   Main(string[] args)
        {
            asyncandawait asyncandawait = new asyncandawait();
         var res=  await asyncandawait.printnumbers();
            Console.WriteLine(res);
            Console.ReadLine();
        }
    }
}
