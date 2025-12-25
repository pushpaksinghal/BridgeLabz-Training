using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgelabzTraining.csharpMethods.level_3
{
    internal class ZaraBonusMethod
    {
        static void Main(String[] args)
        {
            //input the salary and the no of year worked in the company
            double[] yearOfServices = new double[10];
            double[] salary = new double[10];
            Random r = new Random();
            for (int i = 0; i < 10; i++)
            {
                yearOfServices[i] = Convert.ToDouble(Console.ReadLine());
            }
            for (int i = 0; i < 10; i++)
            {
                salary[i] = r.Next(10000, 1000000);
            }
            double[] bonusAmount = bonus(salary, yearOfServices);
            // add the bonus to the current salalry and print the new salary
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("New Salary with Bonus: " + bonusAmount[i]);
            }
            Console.WriteLine(SumBonus(bonusAmount, salary));
        }

        static double[] bonus(double[] salary, double[] yearOfServices)
        {
            double[] bonusAmount = new double[10];

            //if thay have worked more then 5 year then they will get 5% bonus
            for (int i = 0; i < 10; i++)
            {
                if (yearOfServices[i] > 5)
                {
                    bonusAmount[i] = salary[i] + (salary[i] * 0.05);
                }
                else
                {
                    bonusAmount[i] = salary[i] + (salary[i] * 0.02);
                }

            }
            return bonusAmount;

        }
        static double SumBonus(double[] bonusAmount, double[]salary)
        {
            double sum = 0;
            for (int i = 0; i < bonusAmount.Length; i++)
            {
                sum += bonusAmount[i] - salary[i];
            }
            return sum;
        }
    }
}
