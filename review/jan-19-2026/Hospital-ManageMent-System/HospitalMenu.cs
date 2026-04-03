using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Review_3.Hospital_ManageMent_System
{
    internal class HospitalMenu
    {
        Ihospital hospital = new HostipalUtility();

        public void Menu()
        {
            while (true)
            {
                Console.WriteLine("\n1.Add Patient");
                Console.WriteLine("2.Remove In Patient");
                Console.WriteLine("3.Remove Out Patient");
                Console.WriteLine("4.Show In Patients");
                Console.WriteLine("5.Show Out Patients");
                Console.WriteLine("6.Generate In Bill");
                Console.WriteLine("7.Generate Out Bill");
                Console.WriteLine("8.Sort In Patients");
                Console.WriteLine("9.Sort Out Patients");
                Console.WriteLine("0.Exit");

                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1: hospital.AddPaitet(); break;
                    case 2: hospital.InRemovePaitent(Convert.ToInt32(Console.ReadLine())); break;
                    case 3: hospital.OutRemovePaitent(Convert.ToInt32(Console.ReadLine())); break;
                    case 4: hospital.InDisplay(); break;
                    case 5: hospital.OutDisplay(); break;
                    case 6: hospital.InBillGenerate(Convert.ToInt32(Console.ReadLine())); break;
                    case 7: hospital.OutBillGenerate(Convert.ToInt32(Console.ReadLine())); break;
                    case 8: hospital.InSort(); break;
                    case 9: hospital.OutSort(); break;
                    default: return;
                }
            }
        }
    }
}
