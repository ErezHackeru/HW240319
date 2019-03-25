using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqLite240319
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>();

            SQLiteConnection connection = new SQLiteConnection($"Data Source = D:\\HackerU\\SQL_Example.db; Version = 3;");
            connection.Open();
            using (SQLiteCommand cmd = new SQLiteCommand("SELECT * FROM COMPANY",connection))
            {
                using (SQLiteDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        employees.Add(new Employee(Convert.ToInt32(reader.GetValue(0)), reader.GetValue(1).ToString(), 
                            Convert.ToInt32(reader.GetValue(2)), reader.GetValue(3).ToString(), Convert.ToInt32(reader.GetValue(4))));
                        Console.WriteLine($"{reader.GetValue(0), 10} {reader.GetValue(1),10} {reader.GetValue(2),10} {reader.GetValue(3),13} {reader.GetValue(4),10}");
                    }
                }
            }

            connection.Close();
            Console.WriteLine("==========The List: ===============");
            employees.ForEach(n => Console.WriteLine(n));

            Console.ReadLine();
        }
    }
}
