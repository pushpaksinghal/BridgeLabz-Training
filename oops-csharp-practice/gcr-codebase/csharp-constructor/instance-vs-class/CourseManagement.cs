using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgelabzTraining.csharp_constructor_accessmodifiers.Instance_vs_class
{
    internal class CourseManagement
    {
        //Atrbutes
        static string university = "Madav unversity";
        string courseName;
        int duration;
        double fee;
        //constructor
        public CourseManagement(string courseName,int duration, double fee)
        {
            this.courseName = courseName;
            this.duration = duration;  
            this.fee = fee;
        }
        //display method
        public void DisplayCourseDetails()
        {
            Console.WriteLine("the name of the course is " + courseName + " the duration is " + duration + "for " + fee + "ruppe");
        }
        // updateing the name of the university
        public static void UpdateInstituteName(string name)
        {
            university = name;
            Console.WriteLine("the updated name of the university is " + university);
        }

    }

    class Display()
    {
        static void Main(string[] args)
        {
            CourseManagement c1 = new CourseManagement("math", 4, 1000);
            c1.DisplayCourseDetails();

            CourseManagement c2 = new CourseManagement("science", 3, 3000);
            c2.DisplayCourseDetails();

            CourseManagement.UpdateInstituteName("GLA university");
        }
    }
}
