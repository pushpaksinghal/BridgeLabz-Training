using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgelabzTraining.senario_based.Factory_Robot_Hazard_Analyzer
{
    internal class RobotSafetyException:Exception
    {
        public RobotSafetyException(string message) : base(message)
        {
        }
    }
}
