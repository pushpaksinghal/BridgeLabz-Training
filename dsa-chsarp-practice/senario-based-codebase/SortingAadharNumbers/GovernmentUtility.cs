using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgelabzTraining.senario_based.SortingAadharNumbers
{
    internal class GovernmentUtility:IUtiity
    {
        Citizen[] people = new Citizen[10];
        int count = 0;
        public void AddPeople(long aadhar, string name,string dateOfBrith)
        {
            if (count >= 10)
            {
                Console.WriteLine("Array is full");
                return;
            }
            people[count++] = new Citizen(aadhar, name, dateOfBrith);
            Console.WriteLine("User added");
        }

        public void Display()
        {
            for(int i = 0; i < count; i++)
            {
                Console.WriteLine(people[i]);
            }
        }
        public void sort()
        {
            long maxval = maxfind(people);

            for(int i=1; maxval / i > 0; i *= 10)
            {
                CountingSort(people, count, i);
            }
        }

        private long maxfind(Citizen[] arr)
        {
            long maxVal = arr[0].GetAadhar();
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i].GetAadhar() >maxVal)
                {
                    maxVal = arr[i].GetAadhar();
                }
            }
            return maxVal;
        }

        private void CountingSort(Citizen[]people, int lenght, int exp)
        {
            Citizen[] output = new Citizen[lenght];
            int[] count = new int[10];

            for(int i = 0; i < 10; i++)
            {
                count[i] = 0;

            }

            for(int i = 0; i < lenght; i++)
            {
                int idx = ((int)(people[i].GetAadhar()) / exp) % 10;
                count[idx]++;
            }

            for (int i = 1; i < 10; i++)
            {
                count[i] += count[i - 1];
            }

            for (int i = lenght - 1; i >= 0; i--)
            {
                int digit = ((int)(people[i].GetAadhar()) / exp) % 10;
                output[count[digit] - 1] = people[i];
                count[digit]--;
            }

            for(int i = 0; i < lenght; i++)
            {
                people[i] = output[i];
            }
        }

        public  void search(long aadhar)
        {
            int left = 0;
            int right = people.Length;
            while (left <= right)
            {
                int mid = left + (right - left) / 2;

                if (people[mid].GetAadhar() < aadhar)
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid - 1;
                }
            }
        }
    }
}
