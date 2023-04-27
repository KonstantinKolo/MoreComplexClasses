using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            Company company1 = new Company();

            for (int i = 0; i < n; i++)
            {
                string[] line = Console.ReadLine().Split();
                string name = line[0];
                int age = int.Parse(line[1]);
                double salary = double.Parse(line[2]);

                company1.ListOfEmployees.Add(new Employee(name, age, salary));

            }
            foreach (var person in company1.ListOfEmployees)
            {
                person.Print();
            }
        }
    }
}
