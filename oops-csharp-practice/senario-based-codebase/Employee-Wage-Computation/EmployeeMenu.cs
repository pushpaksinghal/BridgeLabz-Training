using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgelabzTraining.senario_based.Employee_Wage_Computation
{
    sealed class EmployeeMenu
    {
        private IEmployee employee;
        public void EmployeeOption()
        {
            bool flag = true;
            employee = new EmployeeUtitlityImp();
            Employee emp1 =null;
            while (flag)
            {
                Console.WriteLine("WELCOME TO EMPLOYEE WAGE COMPUTATION PROGRAM");
                Console.WriteLine("1.Add Employee");
                Console.WriteLine("2.Check Employee Attendance");
                Console.WriteLine("3.Exit");
                int choice = Convert.ToInt32(Console.ReadLine());
                if(choice == 1)
                {
                    emp1 = employee.AddEmployee();
                    Console.WriteLine(emp1);
                    Console.WriteLine("Employee added.");
                }
                else if(choice == 2)
                {
                    employee.Attendance(emp1.GetId());
                }
                else if(choice ==3)
                {
                    Console.WriteLine("Thnaks for visiting");
                    flag = false;
                    break;
                }
            }
        }
    }
}
