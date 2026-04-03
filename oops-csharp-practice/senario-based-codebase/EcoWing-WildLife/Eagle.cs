using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgelabzTraining.senario_based.EcoWing_WildLife
{
    internal class Eagle:Bird,IFlyable
    {
        public string size;
        public Eagle(string size, DateTime dateOfArrival,string environment,string typeOfFood,bool injuried,long birdId) : base(dateOfArrival, environment, typeOfFood, injuried,birdId)
        {
            this.size = size;
        }

        public void Fly()
        {
            Console.WriteLine("Yes, an eagle can fly.");
        }

        public override void Display()
        {
            Console.WriteLine("the id is "+birdId+" the eagle arrived on " + dateOfArrival + " this eagle is habitual in " + environment + " environment and eats " + typeOfFood + " type of food and the size is " + size+ " injury status is " + injuried);
        }
    }
}
