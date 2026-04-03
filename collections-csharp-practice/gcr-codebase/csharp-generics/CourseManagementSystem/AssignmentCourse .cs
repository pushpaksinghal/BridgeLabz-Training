using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgelabzTraining.csharp_generics.CourseManagementSystem
{
    internal class AssignmentCourse : CourseType
    {
        public AssignmentCourse()
        {
            EvaluationName = "Assignment Based";
        }

        public override double Evaluate(double marks)
        {
            // Example: assignments have full weight
            return marks;
        }
    }
}
