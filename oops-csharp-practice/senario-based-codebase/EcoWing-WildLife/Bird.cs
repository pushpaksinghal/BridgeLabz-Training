using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgelabzTraining.senario_based.EcoWing_WildLife
{
    internal abstract class Bird
    {
        protected DateTime dateOfArrival;
        protected string environment;
        protected string typeOfFood;
        protected bool injuried;
        protected long birdId;

        protected Bird(DateTime dateOfArrival,string environment, string typeOfFood, bool injuried, long birdId)
        {
            this.injuried = injuried;
            this.dateOfArrival = dateOfArrival;
            this.environment = environment;
            this.typeOfFood = typeOfFood;
            this.birdId = birdId;
        }
        public abstract void Display();
    }
}
