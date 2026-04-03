using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgelabzTraining.csharp_generics.CourseManagementSystem
{
    namespace BridgelabzTraining.csharp_generics.University
    {
        // Exam-based evaluation
        internal class ExamCourse : CourseType
        {
            public ExamCourse()
            {
                EvaluationName = "Exam Based";
            }

            public override double Evaluate(double marks)
            {
                // Example: exams have 90% weight
                return marks * 0.9;
            }
        }
    }

}
