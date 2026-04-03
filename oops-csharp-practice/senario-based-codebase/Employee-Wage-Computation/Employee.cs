using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgelabzTraining.senario_based.Employee_Wage_Computation
{
    internal class Employee
    {
        private long employeeId {  get; set; }
        private string employeeName {  get; set; }
        private int employeeAge {  get; set; }

        private string employeeEmail { get; set; }


        public Employee(long employeeId, string employeeName, int employeeAge , string employeeEmail)
        {
            this.employeeId = employeeId;
            this.employeeName = employeeName;
            this.employeeAge = employeeAge;
            this.employeeEmail = employeeEmail;
        }

        public long GetId()
        {
            return employeeId;
        }
        public override string ToString()
        {
            return "Name:" + employeeName + "\n Id :" + employeeId + "\n age: " + employeeAge +"\n Email: "+employeeEmail;
        }
    }
}
