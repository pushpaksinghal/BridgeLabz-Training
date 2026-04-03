using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgelabzTraining.senario_based.FitTrack
{
    internal class utility
    {

        List<UserProfile> user;
        public utility()
        {
            user = new List<UserProfile>();
        }

        public UserProfile CreateUser()
        {
            Console.WriteLine("enter name, age, BMI, workout length");
            string name = Console.ReadLine();
            int age = Convert.ToInt32(Console.ReadLine());
            double bmi = Convert.ToDouble(Console.ReadLine());
            int length = Convert.ToInt32(Console.ReadLine());

            UserProfile u = new UserProfile(name, age, bmi, length);
            user.Add(u);

            return u;
        }

        public List<ITrackable> Weeklyworkout(int baseDuration)
        {
            List<ITrackable> weeklyWorkout = new List<ITrackable>();

            Console.WriteLine("Enter the 7 days plan");

            for(int i = 0; i < 7; i++)
            {
                Console.WriteLine("Type of Workout");
                Console.WriteLine("1.Cardio");
                Console.WriteLine("2.Strengh");

                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Enter calBurned, and number o fWarmup Exercise");
                        int cal = Convert.ToInt32(Console.ReadLine());
                        int numexer = Convert.ToInt32(Console.ReadLine());
                        weeklyWorkout.Add(new CardioWorkout(baseDuration, cal, numexer));
                        break;
                    case 2:
                        Console.WriteLine("Enter calBurned, and number of Strengh Exercise");
                        int calS = Convert.ToInt32(Console.ReadLine());
                        int numexerS = Convert.ToInt32(Console.ReadLine());
                        weeklyWorkout.Add(new StrenghtWorkout(baseDuration, calS, numexerS));
                        break;
                }
            }

            return weeklyWorkout;
        }
        
        public int TrackWeek(List<ITrackable> WeekWorkout)
        {
            int completeddays = 0;

            foreach(ITrackable work in WeekWorkout)
            {
                Console.WriteLine("Todays workout Completed :(yes/no)");
                string answer = Console.ReadLine();

                if(answer.ToLower() == "yes" || work.TodaysWorkoutCompleted())
                {
                    completeddays++;
                }
            }
            return completeddays;
        }

        public void StartWorkout(UserProfile user)
        {
            int totalDays = user.GetworkoutLength();
            int weeks = totalDays / 7;
            int InitailDuration = 20; //in min
            int completedDays = 0;
            List<ITrackable>week = Weeklyworkout(InitailDuration);
            for (int i = 0; i < weeks; i++)
            {
                Console.WriteLine("Week " + (i + 1));
                List<ITrackable> weeklyWorkout = week;
                completedDays += TrackWeek(weeklyWorkout);

                InitailDuration += 10;
            }

            UpdateBMI(user, completedDays);
            GenerateReport(user, completedDays);
        }

        public void UpdateBMI(UserProfile user, int completedDays)
        {
            double newChanges = completedDays * 0.5;
            double newBMI = user.GetBMI() - newChanges;

            user.SetBMI(newBMI);
        }

        public void GenerateReport(UserProfile user , int completedDays)
        {
            Console.WriteLine("FINALE REPORT.");
            Console.WriteLine("1. Name " + user.GetName());
            Console.WriteLine("2. Age " + user.GetAge());
            Console.WriteLine("3. Workout Days " + completedDays);
            Console.WriteLine("4. BMI " + user.GetBMI());
            Console.WriteLine();
        }
    }
}
