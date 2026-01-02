using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace BridgelabzTraining.csharp_constructor_accessmodifiers.access_modifiers
{
    internal class University
    {
        static void Main(string[] args)
        {
            student s1 = new student();
            student s2 = new student(0002, "madhav", 8.5);
            PostgraduateStudent s3 = new PostgraduateStudent();

            //using the display method in main
            s1.Display();
            s2.Display();
            s3.display();
        }

    }

    public class student
    {
        //creating the atributes
        public long rollNumber;
        protected string name;
        private double CGPA;
        // constructors
        public student()
        {
            this.name = "jhon";
            this.rollNumber = 0001;
            this.CGPA = 8.2;
        }
        public student(long rollNumber, string name, double CGPA)
        {
            this.name = name;
            this.rollNumber = rollNumber;
            this.CGPA = CGPA;
        }
        // getter and setter for private 
        public double GetCGPA()
        {
            return CGPA;
        }
        
        public void SetCGPA(double cgpa)
        {
            if (cgpa >= 0 && cgpa <= 10)
            {
                CGPA = cgpa;
            }
            else
            {
                Console.WriteLine("invalid CGPA");
            }
        }

        public void Display()
        {
            Console.WriteLine("the roll number is " + rollNumber + " nae of the student is " + name + " and the CGPA is " + GetCGPA());
        }

    }

    public class PostgraduateStudent() : student(0003, "ram", 6.2)
    {
        // display method for child class
        public void display()
        {
            Console.WriteLine("the name of the student is " + name + " with roll number " + rollNumber + " and the CGPA of " + GetCGPA());
        }
    }
}
