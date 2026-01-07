using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace BridgelabzTraining.senario_based.Employee_Wage_Computation
{
    class EmployeeUtitlityImp : IEmployee
    {
        private Employee _employee;
        public Employee AddEmployee()
        {
            Console.WriteLine("Employee Id:");
            long id = Convert.ToInt64(Console.ReadLine());
            if (id.ToString().Length > 6 && id.ToString().Length < 6)
            {
                Console.WriteLine("Id need to be of 6 digits");
                return null;
            }
            Console.WriteLine("Employee Name:");
            string name = Console.ReadLine();
            Console.WriteLine("Employee Age:");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Employee Email:");
            string email = Console.ReadLine();
            if (!email.Contains("@") || !email.Contains("."))
            {
                Console.WriteLine("Invalid Email");
                return null;
            }
            _employee = new Employee(id, name, age, email);
            return _employee;
        }

        public bool Attendance(long employeeId)
        {
            Random random = new Random();
            int empCheck = random.Next(0, 2);
            if (empCheck == 1)
            {
                Console.WriteLine("present");
                return true;
            }
            else
            {
                Console.WriteLine("absent");
                return false;
            }
        }

        // this was version 1

        public void DailyWage(long employeeId)
        {
            int hourlyRate = 20;
            int dailyHours = 8;
            int dailyWage = hourlyRate * dailyHours;
            Console.WriteLine("A Employee Daily Wage is " + dailyWage+" Rupees");
        }
    }
}
