namespace Assignment1_SUM_OF_EVEN
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            int num = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            int[] listofeven = new int[]{ };
            for (int i = 0; i <= num; i++)
            {
                if (i%2!=0 && i!=0)
                {
                    sum += i;
                    listofeven.Append(i);
                }
                
            }
            Console.WriteLine($"Sum of even number from first {num} numbers is: {sum} which are:{listofeven}");
        }
    }
}