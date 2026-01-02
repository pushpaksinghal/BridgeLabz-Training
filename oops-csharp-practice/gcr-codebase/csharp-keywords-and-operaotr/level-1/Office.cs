using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgelabzTraining.keywords_and_operator.level_1
{
    internal class Office
    {
        static void Main(string[] args)
        {
            Employee e1 = new Employee("pushpak", 001, "Dev");
            //using the is opretor
            if (e1 is Employee)
            {
                e1.Display();
            }

            Employee.DisplayTotalEmployees();
        }
    }

    public class Employee
    {
        //static atributes
        public static string CompanyName = "BridgeLabz";
        static int totalEmployees = 0;
        // using thr readonly keyword
        public readonly int Id;
        string Name;
        string Designation;

        public Employee(string Name, int Id, string Designation)
        {
            this.Name = Name;
            this.Id = Id;
            this.Designation = Designation;
            totalEmployees++;
        }

        public static void DisplayTotalEmployees()
        {
            Console.WriteLine(totalEmployees);
        }

        public void Display()
        {
            Console.WriteLine(Name + " " + Id + " " + Designation);
        }
    }
}
