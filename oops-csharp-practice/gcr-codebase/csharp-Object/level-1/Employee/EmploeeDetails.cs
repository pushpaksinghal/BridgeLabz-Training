using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgelabzTraining.csharp_objects.Employee
{
    internal class EmploeeDetails
    {
        string name;
        int id;
        double salary;

        public EmploeeDetails(string name, int id, double salary)
        {
            this.name = name;
            this.id = id;
            this.salary = salary;
        }

        public void Display()
        {
            Console.WriteLine(name);
            Console.WriteLine(id);
            Console.WriteLine(salary);
        }
    }
}
