using System;

namespace BridgelabzTraining.senario_based.Employee_Wage_Computation
{
    sealed class EmployeeMenu
    {
        private IEmployee employee;
        // refactored the file with switch case instead of if else for varsion 4
        public void TypeEmployee()
        {
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("WELCOME TO EMPLOYEE WAGE COMPUTATION PROGRAM");
                Console.WriteLine("1. Full Time Employee");
                Console.WriteLine("2. Part Time Employee");
                Console.WriteLine("3. Exit");

                int which = Convert.ToInt32(Console.ReadLine());
                switch (which)
                {
                    case 1:
                        EmployeeOption();
                        break;
                    case 2:
                        PartEmployeeOption();
                        break;
                    case 3:
                        flag = false;
                        break;
                    default:
                        Console.WriteLine("Invalid choice");
                        break;
                }
            }
        }

        public void EmployeeOption()
        {
            bool flag = true;
            employee = new EmployeeUtitlityImp();
            Employee emp1 = null;
            while (flag)
            {
                Console.WriteLine("WELCOME TO EMPLOYEE WAGE COMPUTATION PROGRAM");
                Console.WriteLine("1. Add Employee");
                Console.WriteLine("2. Check Employee Attendance");
                Console.WriteLine("3. Check Employee Daily Wages");
                Console.WriteLine("4. Check Employees Monthly Wages");
                Console.WriteLine("5. Exit");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        emp1 = employee.AddEmployee();
                        Console.WriteLine(emp1);
                        Console.WriteLine("Employee added.");
                        break;
                    case 2:
                        // added an option to add employee first so that id can be taken
                        if (emp1 != null)
                            if (employee.Attendance(emp1.GetId()))
                            {
                                Console.WriteLine("Employee is present ");
                            }
                            else
                            {
                                Console.WriteLine("Employee is Absent");
                            }
                        else
                                Console.WriteLine("Please add employee first.");
                        break;
                    case 3:
                        if (emp1 != null)
                            employee.DailyWage(emp1.GetId());
                        else
                            Console.WriteLine("Please add employee first.");
                        break;
                    // added a case to find a  employees monthly wages for version 5
                    case 4:
                        if(emp1 != null)
                        {
                            employee.MonthlyWage(emp1.GetId());
                        }
                        else
                        {
                            Console.WriteLine("Please add Employee first");
                        }
                        break;
                    case 5:
                        Console.WriteLine("Thanks for visiting");
                        flag = false;
                        break;
                    default:
                        Console.WriteLine("Invalid choice");
                        break;
                    }
            }
        }
        public void PartEmployeeOption()
        {
            bool flag = true;
            employee = new EmployeeUtitlityImp();
            Employee emp1 = null;
            while (flag)
            {
                Console.WriteLine("Choose");
                Console.WriteLine("1. Add Employee");
                Console.WriteLine("2. Check Employee Daily Wages");
                Console.WriteLine("3. Check  Monthly Wages");
                Console.WriteLine("3. Exit");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        emp1 = employee.AddEmployee();
                        Console.WriteLine(emp1);
                        Console.WriteLine("Employee added.");
                        break;
                    case 2:
                        if (emp1 != null)
                            employee.DailyWage(emp1.GetId());
                        else
                            Console.WriteLine("Please add employee first.");
                        break;
                    // changes added for version 6
                    case 3:
                        if (emp1 != null)
                        {
                            employee.MonthlyWage(emp1.GetId());
                        }
                        else
                        {
                            Console.WriteLine("Please add Employee first");
                        }
                        break;
                    case 4:
                        Console.WriteLine("Thanks for visiting");
                        flag = false;
                        break;
                    default:
                        Console.WriteLine("Invalid choice");
                        break;
                }
            }
        }
    }
}
