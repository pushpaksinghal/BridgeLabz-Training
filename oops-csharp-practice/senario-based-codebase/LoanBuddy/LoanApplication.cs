using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgelabzTraining.senario_based.LoanBuddy
{
    internal class LoanApplication
    {
        private string loanType;
        private int term;
        private double interestRate;

        public LoanApplication(string loanType, int term, double interestRate)
        {
            this.loanType = loanType;
            this.term = term;
            this.interestRate = interestRate;
        }
        public string GetLoanType() { return loanType; }
        public int GetTerm() { return term; }

        public double GetInterestRate() { return interestRate; }
    }
}
