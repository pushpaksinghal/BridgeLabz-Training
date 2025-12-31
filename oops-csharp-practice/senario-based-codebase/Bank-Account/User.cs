using System;

namespace BridgelabzTraining.senario_based.Bank_Account
{
    internal class User
    {
        public string accountNumber;
        public string userName;
        public double balance;
        public string bankname;
        public string codeIFSE;
        private int pin;
        
        public User(int pin, string accountNumber, string userName,string bankname, string codeIFSE, double balance)
        {
            this.pin = pin;
            this.accountNumber = accountNumber;
            this.userName = userName;
            this.bankname = bankname;
            this.codeIFSE = codeIFSE;
            this.balance = balance;
        }
        public bool AuthUser(int inputPin)
        {
            return pin == inputPin;
        }
    }
}
