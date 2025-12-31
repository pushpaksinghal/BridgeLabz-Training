using System;

namespace BridgelabzTraining.senario_based.Bank_Account
{
    internal class Menu
    {
        public static void Start()
        {
            Branch branch = new Branch();

            while (true)
            {
                Console.WriteLine("WELCOME TO B.D.V. Indian Bank");
                Console.WriteLine("1. Manager");
                Console.WriteLine("2. User");
                Console.WriteLine("3. Exit");
                Console.Write("Choose option: ");

                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        ManagerMenu(branch);
                        break;

                    case 2:
                        UserMenu(branch);
                        break;

                    case 3:
                        return;

                    default:
                        Console.WriteLine("Invalid choice");
                        break;
                }
            }
        }
        static void ManagerMenu(Branch branch)
        {
            Console.Write("password: ");
            if (!branch.AuthManager())
            {
                Console.WriteLine("auth failed");
                return;
            }

            while (true)
            {
                Console.WriteLine(" MANAGER MENU");
                Console.WriteLine("1. Add User");
                Console.WriteLine("2. Remove User");
                Console.WriteLine("3. Back");

                int ch = Convert.ToInt32(Console.ReadLine());

                switch (ch)
                {
                    case 1:
                        branch.AddUser();
                        break;

                    case 2:
                        Console.Write("account number: ");
                        string acc = Console.ReadLine();
                        int idx = branch.SearchUser(acc);

                        if (idx == -1)
                        {
                            Console.WriteLine("User not found");
                        }
                        else
                        {
                            branch.RemoveUser(idx);
                            Console.WriteLine("User removed");
                        }
                        break;

                    case 3:
                        return;

                    default:
                        Console.WriteLine("Invalid choice");
                        break;
                }
            }
        }

        static void UserMenu(Branch branch)
        {
            Console.Write("account number");
            string accNo = Console.ReadLine();

            Console.Write("give PIN");
            int pin = Convert.ToInt32(Console.ReadLine());

            int index = branch.AuthUser(accNo, pin);

            if (index == -1)
            {
                Console.WriteLine("Invalid credentials");
                return;
            }

            while (true)
            {
                Console.WriteLine(" USER MENU");
                Console.WriteLine("1. Check Balance");
                Console.WriteLine("2. Deposit");
                Console.WriteLine("3. Withdraw");
                Console.WriteLine("4. Transfer");
                Console.WriteLine("5. Back");

                int ch = Convert.ToInt32(Console.ReadLine());

                switch (ch)
                {
                    case 1:
                        Console.WriteLine("Balance" + branch.GetBalance(index));
                        break;

                    case 2:
                        Console.Write("Enter amount ");
                        branch.UpdateBalance(index, Convert.ToDouble(Console.ReadLine()));
                        break;

                    case 3:
                        Console.Write("Enter amount");
                        branch.UpdateBalance(index, -Convert.ToDouble(Console.ReadLine()));
                        break;

                    case 4:
                        Console.Write("target account ");
                        string target = Console.ReadLine();

                        int targetIndex = branch.SearchUser(target);
                        if (targetIndex == -1)
                        {
                            Console.WriteLine("account not found");
                            break;
                        }

                        Console.Write("Enter amount: ");
                        double amt = Convert.ToDouble(Console.ReadLine());

                        branch.UpdateBalance(index, -amt);
                        branch.UpdateBalance(targetIndex, amt);
                        break;

                    case 5:
                        return;

                    default:
                        Console.WriteLine("Invalid choice");
                        break;
                }
            }
        }
    }
}
