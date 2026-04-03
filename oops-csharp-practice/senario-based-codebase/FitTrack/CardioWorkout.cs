using BridgelabzTraining.chsarp_Encapsulation_abstraction.Library_Management_System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgelabzTraining.senario_based.FitTrack
{
    internal class CardioWorkout: Workout, ITrackable
    {
        private int calBurned;
        private int WarmUpexcercise;

        public void SetcalBurned(int calBurned)
        {
            this.calBurned = calBurned;
        }
        public int GetcalBurned()
        {
            return calBurned;
        }
        public void Setexcercise(int WarmUpexcercise)
        {
            this.WarmUpexcercise = WarmUpexcercise;
        }
        public int Getexcercise()
        {
            return WarmUpexcercise;
        }
        public CardioWorkout(int duration, int calBurned, int WarmUpexcercise) : base(duration)
        {
            this.calBurned = calBurned;
            this.WarmUpexcercise = WarmUpexcercise;
        }

        bool ITrackable.TodaysWorkoutCompleted()
        {
            if (Getduration() >= 20 && calBurned >= 200)
            {
                return true;
            }
            return false;
        }
    }
}
