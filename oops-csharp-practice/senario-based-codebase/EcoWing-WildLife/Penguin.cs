using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgelabzTraining.senario_based.EcoWing_WildLife
{
    internal class Penguin:Bird,ISwimable
    {
        public string size;
        public Penguin(string size, DateTime dateOfArrival, string environment, string typeOfFood, bool injuried,long birdId) : base(dateOfArrival, environment, typeOfFood, injuried,birdId)
        {
            this.size = size;
        }

        public void Swim()
        {
            Console.WriteLine("Yes, an Penguin can Swim.");
        }

        public override void Display()
        {
            Console.WriteLine("id is " + birdId + " the penguin arrived on " + dateOfArrival + " this penguin is habitual in " + environment + " environment and eats " + typeOfFood + " type of food and the size is " + size + " ,injury status is " + injuried);
        }
    }
}
