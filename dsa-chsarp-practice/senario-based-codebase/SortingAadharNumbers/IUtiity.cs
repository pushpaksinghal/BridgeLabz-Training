using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgelabzTraining.senario_based.SortingAadharNumbers
{
    internal interface IUtiity
    {
        void search(long aadhar);
        void sort();
        void Display();
        void AddPeople(long aadhar, string name, string dateOfBrith);
    }
}
