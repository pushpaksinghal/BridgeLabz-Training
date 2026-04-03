using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgelabzTraining.senario_based.FitnessTracker
{
    internal class User
    {
        private string name;
        private int dailyStep;
        private int totalStep;

        public User(string name, int dailyStep)
        {
            this.name = name;
            this.dailyStep = dailyStep;
            totalStep = 0;
        }

        public string GetNmae() { return name; }
        public int GetDailyStep() { return dailyStep; }
        public int GetTotalStep() { return totalStep; }
        public void SetTotalStep(int step) { totalStep = step; }

        public override string ToString()
        {
            return "Name: " + name+"\nDaily Step: "+dailyStep+"\nTotal Step: "+totalStep+"]";
        }
    }
}
