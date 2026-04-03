using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgelabzTraining.csharp_constructor_accessmodifiers.access_modifiers
{
    internal class Records
    {
        static void Main(string[] args)
        {
            Employee e1 = new Employee();
            Employee e2 = new Employee(202, "IT", 45000);
            Manager m1 = new Manager();
            e1.Display();
            e2.Display();
            m1.Display();
        }
    }
    // same as all the previous question
    public class Employee
    {
        public int employeeID;
        protected string department;
        private double salary;
        public Employee()
        {
            this.employeeID = 201;
            this.department = "jhon";
            this.salary = 30000;
        }
        public Employee(int employeeID, string department, double salary)
        {
            this.employeeID = employeeID;
            this.department = department;
            this.salary = salary;
        }
        public double GetSalary()
        {
            return salary;
        }
        public void SetSalary(double salary)
        {
            if (salary > 0)
            {
                this.salary = salary;
            }
            else
            {
                Console.WriteLine("invalid salary");
            }
        }
        public void Display()
        {
            Console.WriteLine("employee id is " + employeeID + " dep is " + department + " salary is " + GetSalary());
        }
    }
    public class Manager() : Employee(203, "Management", 70000)
    {
        // method for child class
        public void Display()
        {
            Console.WriteLine("manager id is " + employeeID + " dep is " + department + " salary is " + GetSalary());
        }
    }
}
