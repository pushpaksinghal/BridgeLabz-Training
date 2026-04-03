using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace BridgelabzTraining.senario_based.Employee_Wage_Computation
{
    internal class EmployeeEntry
    {
        static void Main(string[] args)
        {
            EmployeeMenu menu = new EmployeeMenu();
            //menu.EmployeeOption();
            //changes for version 3
            menu.TypeEmployee();
        }
    }
}
