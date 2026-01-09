using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgelabzTraining.senario_based.FitTrack
{
    internal class Workout
    {
        private int duration;
        public void Setduration(int duration)
        {
            this.duration = duration;
        }
        public int Getduration()
        {
            return duration;
        }
        public Workout(int duration)
        {
            this.duration = duration;
        }
    }
}
