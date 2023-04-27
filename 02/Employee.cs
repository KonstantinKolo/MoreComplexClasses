using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02
{
    class Employee
    {
        private string name;
        private int age;
        private double salary;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int Age
        {
            get { return age; }
            set { age = value; }
        }
        public double Salary
        {
            get { return salary; }
            set { salary = value; }
        }


        public Employee(string name, int age, double salary)
        {
            this.Name = name;
            this.Age = age;
            this.Salary = salary;
        }
        public void Print()
        {
            Console.WriteLine($"The employee {Name} is {Age} years old and receives a salary of BGN {Salary}.");
        }
    }
}
