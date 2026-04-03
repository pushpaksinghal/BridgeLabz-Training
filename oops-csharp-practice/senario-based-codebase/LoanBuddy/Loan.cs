using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgelabzTraining.senario_based.LoanBuddy
{
    internal class Loan
    {
        Applicant applicant;
        LoanApplication Application;
        public Loan(Applicant applicant, LoanApplication application)
        {
            this.applicant = applicant;
            this.Application = application;
        }
        public Applicant GetApplicant() { return applicant; }
        public LoanApplication GetApplication() { return Application; }
    }
}
