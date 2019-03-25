using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqLite240319
{
    class Employee
    {
        public int id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }
        public int Salary { get; set; }

        public Employee(int id, string name, int age, string address, int salary)
        {
            this.id = id;
            Name = name;
            Age = age;
            Address = address;
            Salary = salary;
        }

        public override string ToString()
        {
            return $"Employee id: {id}, Name: {Name}, Age: {Age}, Address: {Address} , Salary: {Salary}.";
        }
    }
}
