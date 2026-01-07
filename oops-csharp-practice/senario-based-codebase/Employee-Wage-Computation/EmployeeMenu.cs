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
        public void TypeEmployee()
        {
            bool flag = true;

            while (flag)
            {
                Console.WriteLine("WELCOME TO EMPLOYEE WAGE COMPUTATION PROGRAM");
                Console.WriteLine("1. Full Time Employee");
                Console.WriteLine("2. Part Time Employee");
                Console.WriteLine("3. Ext");

                int which = Convert.ToInt32(Console.ReadLine());
                if(which == 1)
                {
                    EmployeeOption();
                    break;
                }
                else if (which == 2)
                {
                    PartEmployeeOption();
                }
                else if(which == 3)
                {
                    flag = false;
                    break;
                }
            }
        }
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
                Console.WriteLine("3. Check Employee Daily Wages"); // changes  for version 2
                Console.WriteLine("4.Exit");
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
                //for version 2 to print daily wages of an employee
                else if(choice == 3)
                {
                    employee.DailyWage(emp1.GetId());
                }
                else if (choice == 4)
                {
                    Console.WriteLine("Thnaks for visiting");
                    flag = false;
                    break;
                }
            }
        }
        //added part time employee options 
        public void PartEmployeeOption()
        {
            bool flag = true;
            employee = new EmployeeUtitlityImp();
            Employee emp1 = null;
            while (flag)
            {
                Console.WriteLine("Choose ");
                Console.WriteLine("1.Add Employee");
                Console.WriteLine("2.Check Employee Daily Wages"); // changes  for version 3
                Console.WriteLine("3.Exit");
                int choice = Convert.ToInt32(Console.ReadLine());
                if (choice == 1)
                {
                    emp1 = employee.AddEmployee();
                    Console.WriteLine(emp1);
                    Console.WriteLine("Employee added.");
                }
                //for version 3 to print daily wages of an part employee
                else if (choice == 2)
                {
                    employee.DailyWage(emp1.GetId());
                }
                else if (choice == 3)
                {
                    Console.WriteLine("Thnaks for visiting");
                    flag = false;
                    break;
                }
            }
        }
    }
}
