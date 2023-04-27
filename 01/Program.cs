using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            //Person[] persons = new Person[n];
            List<Person> listOfPersons = new List<Person>();

            for (int i = 0; i < n; i++)
            {
                string[] line = Console.ReadLine().Split();
                string name = line[0];
                int age = int.Parse(line[1]);
                listOfPersons.Add(new Person(name, age));


            }

            foreach (var person in listOfPersons)
            {
                if (person.Age > 30)
                {
                    person.Print();
                }

            }
        }
    }
}
