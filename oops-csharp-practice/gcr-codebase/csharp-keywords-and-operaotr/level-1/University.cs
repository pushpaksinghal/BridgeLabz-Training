using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgelabzTraining.keywords_and_operator.level_1
{
    internal class University
    {
        static void Main(string[] args)
        {
            // creating a obj of class
            Student s1 = new Student("pushpak", 11, "A");
            // is operator
            if (s1 is Student)
            {
                s1.Display();
            }

            Student.DisplayTotalStudents();
        }
    }

    public class Student
    {
        public static string UniversityName = "GLA University";
        static int totalStudents = 0;
        // readonly keyword
        public readonly int RollNumber;
        string Name;
        string Grade;

        public Student(string Name, int RollNumber, string Grade)
        {
            //this keyword
            this.Name = Name;
            this.RollNumber = RollNumber;
            this.Grade = Grade;
            totalStudents++;
        }
        // static method for total student
        public static void DisplayTotalStudents()
        {
            Console.WriteLine(totalStudents);
        }

        public void Display()
        {
            Console.WriteLine(Name + " " + RollNumber + " " + Grade);
        }
    }
}
