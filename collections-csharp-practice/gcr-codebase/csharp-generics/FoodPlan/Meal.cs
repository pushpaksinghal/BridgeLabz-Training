using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgelabzTraining.csharp_generics.FoodPlan
{
    internal class Meal<T> where T : IMealPlan
    {
        public void GenerateMeal<TMeal>(TMeal meal) where TMeal : IMealPlan
        {
            if (meal.Calories < 300)
            {
                Console.WriteLine("Meal rejected: Insufficient calories.");
                return;
            }

            Console.WriteLine("Meal Plan Generated:");
            meal.Display();
        }
    }
}
