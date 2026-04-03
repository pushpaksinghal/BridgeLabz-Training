using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgelabzTraining.csharp_generics.FoodPlan
{
    internal class Foodmenu
    {
        public void start()
        {
            Meal<IMealPlan> mealPlanner = new Meal<IMealPlan>();

            Console.WriteLine("Choose Meal Type:");
            Console.WriteLine("1. Vegetarian");
            Console.WriteLine("2. Vegan");
            Console.Write("Choice: ");
            int choice = int.Parse(Console.ReadLine());

            Console.Write("Enter calories: ");
            int calories = int.Parse(Console.ReadLine());

            if (choice == 1)
            {
                mealPlanner.GenerateMeal(new VegetarianMeal(calories));
            }
            else if (choice == 2)
            {
                mealPlanner.GenerateMeal(new VeganMeal(calories));
            }
            else
            {
                Console.WriteLine("Invalid choice.");
            }
        }
    }
}
