using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgelabzTraining.csharp_generics.CourseManagementSystem
{
    internal class CourseUtility
    {
        private List<Course<CourseType>> courses = new List<Course<CourseType>>();

        public void AddCourse(Course<CourseType> course)
        {
            courses.Add(course);
        }

        public void DisplayCourses()
        {
            foreach (var course in courses)
            {
                System.Console.WriteLine(course);
            }
        }
    }
}
