// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, ");
/*Data Types*/
string name = "Parv";
int id = 65;
float salary = 100010.1f;
double Rating = 4.44;
long Zip = 567890;
short a = 6;
bool isActive = true;
char b = 'a';
//Console.WriteLine(name + id + salary + Rating);
//Console.WriteLine(name+", Enter Your Address");

//Type Casting
//1.Implicit Casting
//2.Explicit Casting

char tc = (char)id;
Console.WriteLine(tc);
int x = Math.Max(22, 44);
Console.WriteLine(x);
Console.WriteLine(name[0]);
Console.WriteLine(name.Substring(1));
Console.WriteLine(name.IndexOf('P'));

//string Address = Console.ReadLine();
//int x = 40;
//Console.Write("Hii"+40+' ');
//Console.Write("What's app");
//Console.WriteLine(Address);


namespace myProgram
{
    public class Program1
    {
        int num1;
        int num2;
        int num3;

        void Add()
        {
            num3 = num1 + num2;
            Console.WriteLine(num3);
        }
        void Sub()
        {
            num3 = num1 - num2;
            Console.WriteLine(num3);
        }
        public static void Main(string[] args)
        {
            Program1 obj = new Program1();
            obj.num1 = 10;
            obj.num2 = 20;
            obj.Add();
            obj.Sub();
        }
    
}




}





