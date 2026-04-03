using BridgelabzTraining.csharp_generics.CourseManagementSystem.BridgelabzTraining.csharp_generics.University;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgelabzTraining.csharp_generics.CourseManagementSystem
{
    internal class CourseMenu
    {
        CourseUtility utility = new CourseUtility();

        public void StartMenu()
        {
            bool flag = true;

            while (flag)
            {
                Console.WriteLine("UNIVERSITY COURSE MANAGEMENT");
                Console.WriteLine("1. Add Course");
                Console.WriteLine("2. Display Courses");
                Console.WriteLine("3. Exit");

                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("1. Exam Course\n2. Assignment Course");
                        int type = Convert.ToInt32(Console.ReadLine());

                        Console.Write("Course Name: ");
                        string name = Console.ReadLine();

                        Console.Write("Marks: ");
                        double marks = Convert.ToDouble(Console.ReadLine());

                        if (type == 1)
                        {
                            utility.AddCourse(
                                new Course<CourseType>(name, marks, new ExamCourse()));
                        }
                        else
                        {
                            utility.AddCourse(
                                new Course<CourseType>(name, marks, new AssignmentCourse()));
                        }
                        break;

                    case 2:
                        utility.DisplayCourses();
                        break;

                    default:
                        flag = false;
                        break;
                }
            }
        }
    }
}
