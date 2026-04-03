using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgelabzTraining.senario_based.LoanBuddy
{
    internal interface IApproveable
    {
        bool ApproveLoan();
        double CalculateEmi();
    }
}
