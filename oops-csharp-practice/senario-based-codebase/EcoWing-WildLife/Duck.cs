using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgelabzTraining.senario_based.EcoWing_WildLife
{
    internal class Duck:Bird,ISwimable
    {
        public string size;
        public Duck(string size, DateTime dateOfArrival, string environment, string typeOfFood, bool injuried,long birdId) : base(dateOfArrival, environment, typeOfFood, injuried,birdId)
        {
            this.size = size;
        }

        public void Swim()
        {
            Console.WriteLine("Yes, an Duck can Swim.");
        }

        public override void Display()
        {
            Console.WriteLine("id is " + birdId + " the duck arrived on " + dateOfArrival + " this duck is habitual in " + environment + " environment and eats " + typeOfFood + " type of food and the size is " + size + " ,injury status is " + injuried);
        }
    }
}
