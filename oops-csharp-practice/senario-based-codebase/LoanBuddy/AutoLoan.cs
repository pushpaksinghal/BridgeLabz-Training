using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgelabzTraining.senario_based.LoanBuddy
{
    internal class AutoLoan: Loan, IApproveable
    {

        public AutoLoan(Applicant applicant, LoanApplication application) : base(applicant, application)
        {
        }

        public bool ApproveLoan()
        {
            if (GetApplicant().GetCreditScore() >= 730 && GetApplicant().GetIncome() >= 35000)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public double CalculateEmi()
        {
            double r = GetApplication().GetInterestRate() / (12 * 100);
            int n = GetApplication().GetTerm() * 12;
            double p = GetApplicant().GetLoanAmount();
            double emi = (p * r * Math.Pow(1 + r, n)) / (Math.Pow(1 + r, n) - 1);
            return emi;
        }
    }
}
