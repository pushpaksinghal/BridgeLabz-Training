using System;

namespace BridgelabzTraining.senario_based.Bank_Account
{
    internal class Bank
    {
        static string bankName = "B.D.V. Indian Bank";
        double minBalance = 0.00;
        double maxTransaction = 100000.00;
        public bool isBalanceMaintaied(double amount)
        {
            return amount>0 && amount<=maxTransaction;
        }

        public bool IsBalanceAble(double amount, double balance)
        {
            return (balance - amount) >= minBalance;
        }
    }
}
