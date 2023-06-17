using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Configuration;
using System.Globalization;
using System.Text.Json;


namespace ConsoleApp4
{
    class product
    {
        public int ProductID { get; set; }
        public string Name { get; set; }
        public override string ToString()
        {
            return $"{ProductID},{Name}";
        }
    }
    internal class filehandling
    {
        void filewrite(product product)
        {
            string json = JsonSerializer.Serialize<product>(product);
            FileStream fileStream = new FileStream(@"d:\test.json", FileMode.Append, FileAccess.Write);
            StreamWriter writer = new StreamWriter(fileStream);
            writer.WriteLine(json);
            writer.Close();
            fileStream.Close();
        }
        void fileread()
        {
            List<product> products= new List<product>();
            FileStream fileStream = new FileStream(@"d:\test.json", FileMode.Open, FileAccess.Read);
            StreamReader streamReader=new StreamReader(fileStream);
           string message= streamReader.ReadLine();
           // product product1 = JsonSerializer.Deserialize<product>(message);
            //Console.WriteLine(product1);
         //   Console.WriteLine(message);
            while(message!=null)
            {
                product product1 = JsonSerializer.Deserialize<product>(message);
                Console.WriteLine(product1);
                // string[] array = message.Split(',');
                // product product = new product() { Name = array[1], ProductID =Convert.ToInt32( array[0]) };
                products.Add(product1);
             //   Console.WriteLine(message);
                message = streamReader.ReadLine();
            }

            foreach (var item in products)
            {
                Console.WriteLine(item);
            }
           
           // Console.WriteLine( streamReader.ReadToEnd());
            streamReader.Close();
            fileStream.Close();
        }
        static void Main(string[] args)
        {
            filehandling filehandling = new filehandling();
          //  filehandling.filewrite(new product() { Name = "abc", ProductID = 1 });
            Console.WriteLine("Enter 3 productID Enter productname");
            for (int i = 0; i < 3; i++)
            {
                product p = new product() { Name = Console.ReadLine(), ProductID = Convert.ToInt32(Console.ReadLine()) };

                filehandling.filewrite(p);

            }

            // DirectoryInfo directoryInfo = new DirectoryInfo(@"d:\\Training Material");
            //DirectoryInfo[] array= directoryInfo.GetDirectories();
            // foreach (var item in array)
            // {
            //     Console.WriteLine(item.FullName);
            //     DirectoryInfo directoryInfo1 = new DirectoryInfo( item.FullName);
            //     DirectoryInfo[] array1= directoryInfo1.GetDirectories();
            //     foreach (var item1 in array1)
            //     {
            //         Console.WriteLine("___" + item1.Name);
            //        FileInfo[] fileInfos= item1.GetFiles();
            //         foreach (var files in fileInfos)
            //         {
            //             Console.WriteLine($"{files.Name} -- {files.Extension}");
            //         }
            //     }

            // }
            filehandling.fileread();
            Console.ReadLine();
        }
    }
}
