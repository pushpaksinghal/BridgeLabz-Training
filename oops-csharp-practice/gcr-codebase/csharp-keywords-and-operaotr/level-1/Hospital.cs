using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgelabzTraining.keywords_and_operator.level_1
{
    internal class Hospital
    {
        static void Main(string[] args)
        {
            Patient p1 = new Patient("Sita", 30, "Fever", 501);
            // is operator
            if (p1 is Patient)
            {
                p1.Display();
            }

            Patient.GetTotalPatients();
        }
    }

    public class Patient
    {
        public static string HospitalName = "City Hospital";
        static int totalPatients = 0;
        //readonly keyword
        public readonly int PatientID;
        string Name;
        int Age;
        string Ailment;

        public Patient(string Name, int Age, string Ailment, int PatientID)
        {
            this.Name = Name;
            this.Age = Age;
            this.Ailment = Ailment;
            this.PatientID = PatientID;
            totalPatients++;
        }
        // method static for total patients
        public static void GetTotalPatients()
        {
            Console.WriteLine(totalPatients);
        }

        public void Display()
        {
            Console.WriteLine(Name + " " + Age + " " + Ailment);
        }
    }
}
