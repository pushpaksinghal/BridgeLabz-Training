using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgelabzTraining.senario_based.FitnessTracker
{
    internal class GroupUtility: IGroup
    {
        User[]arr = new User[20];
        int count = 0;
        public void AddUser()
        {
            Console.WriteLine("Enter t your name and daily steps");
            string name = Console.ReadLine();
            int dailyStep =Convert.ToInt32(Console.ReadLine());

            arr[count++] = new User(name, dailyStep);

            Console.WriteLine("User added.");
        }

        public void BubbleSortUser()
        {
            int n = arr.Length;
            bool swapped;
            for (int i = 0; i < n - 1; i++)
            {
                swapped = false;
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (arr[j].GetTotalStep() < arr[j + 1].GetTotalStep())
                    {
                        (arr[j], arr[j + 1]) = (arr[j + 1], arr[j]);
                        swapped = true;
                    }
                }
                if (!swapped) break;
            }
        }
        public void AddSteps()
        {
            for(int i = 0; i < arr.Length; i++)
            {
                arr[i].SetTotalStep(arr[i].GetTotalStep() + arr[i].GetDailyStep());
            }
        }
        public void LeaderBoard()
        {
            for(int i = 0; i < 10; i++)
            {
                Console.Write(arr[i]);
            }
        }
    }
}
