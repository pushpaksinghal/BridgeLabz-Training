using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgelabzTraining.csharp_generics.CourseManagementSystem
{
    internal abstract class CourseType
    {
        public string EvaluationName { get; protected set; }

        // Each course type evaluates marks differently
        public abstract double Evaluate(double marks);
    }
}
