using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgelabzTraining.senario_based.Employee_Wage_Computation
{
    internal interface IEmployee
    {
        Employee AddEmployee();
        public bool Attendance(long employeeId);

        // this was version one

        public void DailyWage(long employeeId);
    }
}
