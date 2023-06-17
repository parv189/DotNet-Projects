using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;

namespace LinkQ1
{
    internal class Program
    {
        public int Emp_ID { get; set; }
        public string Emp_Name { get; set; }

        public int Manager_ID { get; set; }

        public int Project_ID { get; set; }
        static void Main(string[] args)
        {
            SqlConnection conn = new SqlConnection("Data Source=PC0404\\MSSQL2019;Initial Catalog=practice1;Integrated Security=True");

            conn.Open();

            List<Program> list = new List<Program>();
            
            

            SqlCommand cmd = new SqlCommand("select * from a.Employee",conn);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                Console.WriteLine(reader["Emp_ID"] +"\t"+ reader["Emp_Name"] +"\t"+ reader["Manager_ID"] +"\t"+ reader["Project_ID"]);
//                list.Add(new Program(){Emp_ID = reader["Emp_Name"],reader["Emp_Name"],reader["Manager_ID"],reader["Project_ID"]});
                list.Add(new Program(){ Emp_ID = Convert.ToInt32(reader["Emp_ID"]), Emp_Name = reader["Emp_Name"].ToString(),
                    Manager_ID= Convert.ToInt32(reader["Manager_ID"]),
                    Project_ID = Convert.ToInt32(reader["Project_ID"])});

            };
            foreach (Program s in list)
            {
            Console.WriteLine("{0}{1}",s.Emp_Name,s.Project_ID);
            };
            Console.ReadLine();
        }
    }

}
