using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02
{
    class Company
    {
        List<Employee> listOfEmployees = new List<Employee>();

        public List<Employee> ListOfEmployees
        {
            get { return listOfEmployees; }
            set { listOfEmployees = value; }
        }
    }
}
