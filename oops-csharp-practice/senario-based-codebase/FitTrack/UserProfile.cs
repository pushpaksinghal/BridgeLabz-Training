using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgelabzTraining.senario_based.FitTrack
{
    internal class UserProfile
    {
        private int workoutLength;
        private string name;
        private int age;
        private double BMI;
        private List<Workout> workouts;

        public void SetworkoutLength(int workoutLength)
        {
            this.workoutLength = workoutLength;
        }
        public int GetworkoutLength()
        {
            return workoutLength;
        }
        public void SetName(string name)
        {
            this.name = name;
        }
        public string GetName()
        {
            return name;
        }
        public void SetAge(int age)
        {
            this.age = age;
        }
        public double GetAge()
        {
            return age;
        }
        public void SetBMI(double BMI)
        {
            this.BMI = BMI;
        }
        public double GetBMI()
        {
            return BMI;
        }

        public UserProfile(string name, int age, double BMI,int workoutlength)
        {
            this.name = name;
            this.age = age;
            this.BMI = BMI;
            this.workoutLength = workoutlength;
            workouts = new List<Workout>();
        }


    }
}
