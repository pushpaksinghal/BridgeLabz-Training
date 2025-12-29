using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgelabzTraining.senario_based
{
    internal class StudentScores
    {
        static void Main(string[] args)
        {
            //create an object on the class
            StudentScores obj = new StudentScores();
            // input the number of student
            int Students = Convert.ToInt32(Console.ReadLine());
            // take the marks of all students
            double[] marks = obj.InputScores(Students);
            obj.highest(marks);
            obj.Lowest(marks);
            obj.AboveAverage(marks);

        }
        double[] InputScores(int n)
        {
            double[] scores = new double[n];
            for (int j = 0; j < n; j++)
            {
                double temp = Convert.ToDouble(Console.ReadLine());
                if (!(temp < 0))
                {
                    scores[j] = temp;
                }
                else
                {
                    Console.Error.WriteLine("invalid input");
                }

            }
            return scores;
        }

        double averageScore(double[] scores)
        {
            //average of all teh scores of the student
            double average = 0;
            for (int i = 0; i < scores.Length; i++)
            {
                average += scores[i];
            }
            return average / scores.Length;

        }

        void highest(double[] scores)
        {
            // takeing the highest score
            double max = 0;
            for (int i = 0; i < scores.Length; i++)
            {
                if (scores[i] > max)
                {
                    max = scores[i];
                }
            }
            Console.WriteLine(max);
        }

        void Lowest(double[] scores)
        {
            // takingthe lowest score
            double min = scores[0];
            for (int i = 0; i < scores.Length; i++)
            {
                if (scores[i] < min)
                {
                    min = scores[i];
                }
            }
            Console.WriteLine(min);
        }

        void AboveAverage(double[] scores)
        {
            //taking all teh scores above the average
            double average = averageScore(scores);
            for (int i = 0; i < scores.Length; i++)
            {
                if (scores[i] > average)
                {
                    Console.WriteLine(scores[i]);
                }
            }
        }
    }
}
