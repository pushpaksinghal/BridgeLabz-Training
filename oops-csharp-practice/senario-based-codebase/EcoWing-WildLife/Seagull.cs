using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgelabzTraining.senario_based.EcoWing_WildLife
{
    internal class Seagull:Bird,IFlyable,ISwimable
    {
        public string size;
        public Seagull(string size, DateTime dateOfArrival, string environment, string typeOfFood, bool injuried, long birdId) : base(dateOfArrival, environment, typeOfFood, injuried, birdId)
        {
            this.size = size;
        }

        public void Swim()
        {
            Console.WriteLine("Yes, an seagull can Swim.");
        }
        public void Fly()
        {
            Console.WriteLine("Yes, an seagull can fly.");
        }

        public override void Display()
        {
            Console.WriteLine("id is " + birdId + " the seagull arrived on " + dateOfArrival + " this seagull is habitual in " + environment + " environment and eats " + typeOfFood + " type of food and the size is " + size + " ,injury status is " + injuried);
        }
    }
}
