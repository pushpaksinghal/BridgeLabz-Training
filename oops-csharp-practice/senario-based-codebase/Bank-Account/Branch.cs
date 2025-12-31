using System;

namespace BridgelabzTraining.senario_based.Bank_Account
{
    internal class Branch
    {
        string branchName = "Tees";
        static string codeIFSC = "TMK6UC893RG";
        private string password = "343S532E89UP";
        string manager;
        User[] userList;
        public int index = 0;

        public Branch()
        {
            Console.Write("no of user ");
            int n = Convert.ToInt32(Console.ReadLine());
            userList = new User[n];
        }
        public bool AuthManager()
        {
            string auth = Console.ReadLine();
            return auth == password;
        }

        public void AddUser()
        {
            string userName = Console.ReadLine();
            double balance = Convert.ToDouble(Console.ReadLine());
            string accountNumber = Console.ReadLine();
            string bankname = Console.ReadLine();
            string codeIFSE = "TMK6UC893RG";
            int pin = Convert.ToInt32(Console.ReadLine());

            if (index == userList.Length)
            {
                userList = ResizeArray(userList, index + 1);
            }

            userList[index] = new User(pin, accountNumber, userName, bankname, codeIFSE, balance);
            index++;
        }

        private User[] ResizeArray(User[] oldArray, int newSize)
        {
            User[] newArray = new User[newSize];
            int limit = Math.Min(oldArray.Length, newSize);

            for (int i = 0; i < limit; i++)
            {
                newArray[i] = oldArray[i];
            }
            return newArray;
        }

        public void RemoveUser(int removeIndex)
        {
            if (removeIndex < 0 || removeIndex >= index)
            {
                Console.WriteLine("Invalid index");
                return;
            }

            userList[removeIndex] = userList[index - 1];
            userList[index - 1] = null;
            index--;
        }

        public void UpdateBalance(int index, double amount)
        {
            if (index < 0 || index >= this.index || userList[index] == null)
            {
                Console.WriteLine("Invalid user index");
                return;
            }

            Bank obj = new Bank();
            double balance = userList[index].balance;

            if (obj.isBalanceMaintaied(Math.Abs(amount)) && (amount > 0 || obj.IsBalanceAble(amount, balance)))
            {
                if(!((userList[index].balance + amount) < 0))
                {
                    userList[index].balance += amount;
                    Console.WriteLine("Balance updated");
                }
                else
                {
                    Console.WriteLine("Balance violation");
                }
                
            }
            else
            {
                Console.WriteLine("Balance violation");
            }
        }

        public int SearchUser(string userAccountNumber)
        {
            for (int i = 0; i < index; i++)
            {
                if (userList[i].accountNumber == userAccountNumber)
                {
                    return i;
                }
            }
            return -1;
        }

        public double GetBalance(int index)
        {
            return userList[index].balance;
        }

        public User[] GetUsers()
        {
            return userList;
        }

        public int AuthUser(string accNo, int pin)
        {
            int index = SearchUser(accNo);

            if (index == -1)
                return -1;

            if (userList[index].AuthUser(pin))
                return index;

            return -1;
        }
    }
}
