using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgelabzTraining.senario_based.FitTrack
{
    internal class StrenghtWorkout:Workout,ITrackable
    {
        private int calBurned;
        private int Strenghtexcercise;

        public void SetcalBurned(int calBurned)
        {
            this.calBurned = calBurned;
        }
        public int GetcalBurned()
        {
            return calBurned;
        }
        public void Setexcercise(int Strenghtexcercise)
        {
            this.Strenghtexcercise = Strenghtexcercise;
        }
        public int Getexcercise()
        {
            return Strenghtexcercise;
        }
        public StrenghtWorkout(int duration, int calBurned, int Strenghtexcercise) : base(duration)
        {
            this.calBurned = calBurned;
            this.Strenghtexcercise = Strenghtexcercise;
        }

        bool ITrackable.TodaysWorkoutCompleted()
        {
            if (Getduration() >= 20 && Strenghtexcercise>=3)
            {
                return true;
            }
            return false;
        }
    }
}
