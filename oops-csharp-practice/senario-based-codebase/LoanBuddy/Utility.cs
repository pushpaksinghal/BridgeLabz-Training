using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgelabzTraining.senario_based.LoanBuddy
{
    internal class Utility
    {
        IApproveable loan;

        public void InputDetail()
        {
            string name =  Console.ReadLine();
            int creditScore = Convert.ToInt32(Console.ReadLine());
            int income = Convert.ToInt32(Console.ReadLine());
            int loanAmount = Convert.ToInt32(Console.ReadLine());

            Applicant applicant = new Applicant(name, creditScore, income, loanAmount);

            string loanType = Console.ReadLine();
            int term = Convert.ToInt32(Console.ReadLine());
            double interestRate = Convert.ToDouble(Console.ReadLine());

            LoanApplication application = new LoanApplication(loanType, term, interestRate);

            if(loanType.Equals("Home"))
            {
                loan = new HomeLoan(applicant, application);
            }
            else if(loanType.Equals("Personal"))
            {
                loan = new PersonalLoan(applicant, application);
            }
            else if(loanType.Equals("Auto"))
            {
                loan = new AutoLoan(applicant, application);
            }
            else
            {
                Console.WriteLine("Invalid Loan Type");
                return;
            }
        }

        public void GetLoanStatus()
        {
            if (loan.ApproveLoan())
            {
                Console.WriteLine("Loan Approved");
                double emi = loan.CalculateEmi();
                Console.WriteLine("EMI: " + emi);
            }
            else
            {
                Console.WriteLine("Loan Rejected");
            }
            
        }

    }
}
