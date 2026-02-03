using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace BridgelabzTraining.senario_based.Factory_Robot_Hazard_Analyzer
{
    internal class HazardMain
    {
        public static void Main(String[] args)
        {
            RobotHazardAuditor r1 = new RobotHazardAuditor();
            r1.Entry();
        }
        
    }
}
