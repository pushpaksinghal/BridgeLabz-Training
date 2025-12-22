using System;

class GradeCalculation {
    static void Main(String[] args) {
        // input marks
        double physics = Convert.ToDouble(Console.ReadLine());
        double chemistry = Convert.ToDouble(Console.ReadLine());
        double maths = Convert.ToDouble(Console.ReadLine());
        //avergaing the marks 
        double average = (physics + chemistry + maths) / 3;

        Console.WriteLine("Average Mark is " + average);
        // giving grades
        if (average >= 80) {
            Console.WriteLine("Grade: A");
            Console.WriteLine("Remarks: Level-4 Above Agency-normalized standerds");
        } else if (average >= 70 &&average <= 79 ) {
            Console.WriteLine("Grade: B");
            Console.WriteLine("Remarks:  Level-3 at Agency-normalized standerds");
        } else if (average >= 60 &&average <= 69) {
            Console.WriteLine("Grade: C");
            Console.WriteLine("Remarks:  Level-2 below but approcching Agency-normalized standerds");
        } else if (average >= 50 &&average <= 59) {
            Console.WriteLine("Grade: D");
            Console.WriteLine("Remarks:  Level-1 well below the  Agency-normalized standerds");
        } else if (average >= 40 &&average <= 49) {
            Console.WriteLine("Grade: E");
            Console.WriteLine("Remarks:  Level-1- too below Agency-normalized standerds");
        } else {
            Console.WriteLine("Grade: R");
            Console.WriteLine("Remarks: Remidial Standerds");
        }
    }
}
