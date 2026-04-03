using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgelabzTraining.senario_based.EduResult
{
    internal class StudentMarks
    {
        protected string studentName;
        protected double marks;

        public StudentMarks(string name, double marks)
        {
            this.studentName = name;
            this.marks = marks;
        }

        public string GetStudentName() { return studentName; }
        public double GetMarks() { return marks; }

        public override string ToString()
        {
            return "Name: " + studentName + "\nMarks: " + marks;
        }
    }
}
