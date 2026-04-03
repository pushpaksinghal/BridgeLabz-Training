using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Review_3.Hospital_ManageMent_System
{
    internal class HostipalMain
    {
        public static void Main(String[] args)
        {
            HospitalMenu menu = new HospitalMenu();
            menu.Menu();
        }
    }
}
