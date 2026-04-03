using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Review_3.Hospital_ManageMent_System
{
    internal class HostipalUtility : Ihospital
    {
        InPaitent[] inPatients = new InPaitent[10];
        OutPaitent[] outPatients = new OutPaitent[10];

        int inCount = 0;
        int outCount = 0;

        public void AddPaitet()
        {
            Console.WriteLine("1. In Patient");
            Console.WriteLine("2. Out Patient");

            int choice = Convert.ToInt32(Console.ReadLine());

            if (choice == 1 && inCount < inPatients.Length)
            {
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Illness: ");
                string illness = Console.ReadLine();
                Console.Write("Id: ");
                int id = Convert.ToInt32(Console.ReadLine());
                Console.Write("Days: ");
                int days = Convert.ToInt32(Console.ReadLine());
                Console.Write("Room Id: ");
                int room = Convert.ToInt32(Console.ReadLine());

                inPatients[inCount++] = new InPaitent(name, illness, id, days, room);
            }
            else if (choice == 2 && outCount < outPatients.Length)
            {
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Illness: ");
                string illness = Console.ReadLine();
                Console.Write("Id: ");
                int id = Convert.ToInt32(Console.ReadLine());
                Console.Write("Hours: ");
                int hours = Convert.ToInt32(Console.ReadLine());
                Console.Write("Room Id: ");
                int room = Convert.ToInt32(Console.ReadLine());

                outPatients[outCount++] = new OutPaitent(name, illness, id, hours, room);
            }
            else
            {
                Console.WriteLine("List Full");
            }
        }

        public void InDisplay()
        {
            for (int i = 0; i < inCount; i++)
                Console.WriteLine(inPatients[i]);
        }

        public void OutDisplay()
        {
            for (int i = 0; i < outCount; i++)
                Console.WriteLine(outPatients[i]);
        }

        public void InRemovePaitent(int index)
        {
            if (index < 0 || index >= inCount)
            {
                Console.WriteLine("Invalid Index");
                return;
            }

            inPatients[index] = inPatients[inCount - 1];
            inPatients[inCount - 1] = null;
            inCount--;
        }

        public void OutRemovePaitent(int index)
        {
            if (index < 0 || index >= outCount)
            {
                Console.WriteLine("Invalid Index");
                return;
            }

            outPatients[index] = outPatients[outCount - 1];
            outPatients[outCount - 1] = null;
            outCount--;
        }

        public void InBillGenerate(int index)
        {
            if (index < 0 || index >= inCount) return;
            Console.WriteLine("Bill: " + inPatients[index].CalculateBill());
        }

        public void OutBillGenerate(int index)
        {
            if (index < 0 || index >= outCount) return;
            Console.WriteLine("Bill: " + outPatients[index].CalculateBill());
        }

        public void InSort()
        {
            QuickSort(inPatients, 0, inCount - 1);
        }

        public void OutSort()
        {
            QuickSort(outPatients, 0, outCount - 1);
        }

        private void QuickSort(Paitent[] arr, int low, int high)
        {
            if (low < high)
            {
                int pi = Partition(arr, low, high);
                QuickSort(arr, low, pi - 1);
                QuickSort(arr, pi + 1, high);
            }
        }

        private int Partition(Paitent[] arr, int low, int high)
        {
            double pivot = arr[high].CalculateBill();
            int i = low - 1;

            for (int j = low; j < high; j++)
            {
                if (arr[j].CalculateBill() < pivot)
                {
                    i++;
                    var temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                }
            }

            var temp1 = arr[i + 1];
            arr[i + 1] = arr[high];
            arr[high] = temp1;

            return i + 1;
        }
    }
}
