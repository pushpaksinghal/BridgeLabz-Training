using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgelabzTraining.csharp_generics.CourseManagementSystem
{
    internal class Course<T> where T : CourseType
    {
        private string courseName;
        private double marks;
        private T courseType;

        public Course(string name, double marks, T type)
        {
            this.courseName = name;
            this.marks = marks;
            this.courseType = type;
        }

        // Applies evaluation logic based on course type
        public double GetFinalScore()
        {
            return courseType.Evaluate(marks);
        }

        public override string ToString()
        {
            return "Course: "+courseName+"\nType: "+courseType.EvaluationName+"\nFinal Score: "+GetFinalScore();
        }
    }
}
