using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgelabzTraining.csharp_generics.FoodPlan
{
    public interface IMealPlan
    {
        string MealName { get; }
        int Calories { get; }
        void Display();
    }
}
