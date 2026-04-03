using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgelabzTraining.senario_based.SortingAadharNumbers
{
    internal class Citizen
    {
        private long aadhar;
        private string name;
        private string dateOfBirth;

        public Citizen(long aadhar, string name, string dateOfBirth)
        {
            this.aadhar = aadhar;
            this.name = name;
            this.dateOfBirth = dateOfBirth;
        }

        public long GetAadhar() { return aadhar; }

        public override string ToString()
        {
            return "Name: " + name + "\n Aadhar number : " + aadhar + "\n Date Of Brith: " + dateOfBirth;
        }
    }
}
