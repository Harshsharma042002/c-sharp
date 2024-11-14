using System;
using System.Collections.Generic;

public class BankingManagement
{
    public class Account
    {
        public string AccountNumber { get; private set; }
        public string AccountHolderName { get; private set; }
        public string Password { get; private set; }
        public decimal Balance { get; private set; }
        public List<string> TransactionHistory { get; private set; }

        public Account(string accountNumber, string accountHolderName, string password, decimal initialDeposit)
        {
            AccountHolderName = accountHolderName;
            AccountNumber = accountNumber;
            Password = password;
            Balance = initialDeposit;
            TransactionHistory = new List<string>();
            TransactionHistory.Add($"Account created with initial amount: {initialDeposit:C}");
        }

        public void Deposit(decimal amount)
        {
            if (amount > 0)
            {
                Balance += amount;
                TransactionHistory.Add($"Deposited: {amount:C}");
                Console.WriteLine($"Successfully deposited {amount:C}.");
            }
            else
            {
                Console.WriteLine("Deposit amount must be positive.");
            }
        }

        public bool Withdraw(decimal amount)
        {
            if (amount > Balance)
            {
                Console.WriteLine("Insufficient balance.");
                return false;
            }
            else if (amount <= 0)
            {
                Console.WriteLine("Withdrawal amount should be positive.");
                return false;
            }
            Balance -= amount;
            TransactionHistory.Add($"Withdrawn: {amount:C}");
            Console.WriteLine($"Successfully withdrawn {amount:C}.");
            return true;
        }

        public void ShowTransactionHistory()
        {
            Console.WriteLine("\n-- Transaction History --");
            foreach (var transaction in TransactionHistory)
            {
                Console.WriteLine(transaction);
            }
        }

        public void CheckBalance()
        {
            Console.WriteLine($"Current Balance: {Balance:C}");
        }

        public void AddInterest(decimal annualRate = 3.0m)
        {
            decimal monthlyInterestRate = annualRate / 12;
            decimal interest = Balance * (monthlyInterestRate / 100);
            Balance += interest;

            TransactionHistory.Add($"Interest of {interest:C} added at {monthlyInterestRate}% monthly rate.");
            Console.WriteLine($"Interest of {interest:C} added at {monthlyInterestRate}% monthly rate. New balance: {Balance:C}");
        }

        public void ChangePassword()
        {
            Console.Write("Enter your current password: ");
            string currentPassword = Console.ReadLine();
            if (currentPassword == Password)
            {
                Console.Write("Enter your new password: ");
                string newPassword = Console.ReadLine();
                Password = newPassword;
                Console.WriteLine("Password changed successfully.");
            }
            else
            {
                Console.WriteLine("Incorrect current password!");
            }
        }
    }

    public class Bank
    {
        private List<Account> accounts = new List<Account>();

        public void CreateAccount()
        {
            Console.Write("Enter Account Holder's Name: ");
            string name = Console.ReadLine();

            Console.Write("Set Account Password: ");
            string password = Console.ReadLine();

            Console.Write("Enter Initial Deposit: ");
            decimal initialDeposit;
            while (!decimal.TryParse(Console.ReadLine(), out initialDeposit) || initialDeposit < 0)
            {
                Console.WriteLine("Please enter a valid positive amount.");
            }

            string accountNumber = $"ACC{accounts.Count + 1:D3}";
            Account newAccount = new Account(accountNumber, name, password, initialDeposit);
            accounts.Add(newAccount);
            Console.WriteLine($"Account created successfully! Your Account Number is {accountNumber}.");
        }

        public Account Login()
        {
            Console.Write("Enter Account Holder's Name: ");
            string name = Console.ReadLine();

            Console.Write("Enter Password: ");
            string password = Console.ReadLine();

            foreach (var account in accounts)
            {
                if (account.AccountHolderName.Equals(name, StringComparison.OrdinalIgnoreCase) && account.Password == password)
                {
                    Console.WriteLine($"Welcome back, {account.AccountHolderName}!");
                    return account;
                }
            }
            Console.WriteLine("Invalid credentials. Try again.");
            return null;
        }
    }

    public static void BankingManagementSystem()
    {
        Bank bank = new Bank();
        bool exit = false;

        while (!exit)
        {
            Console.WriteLine("\n--- BANKING MENU ---");
            Console.WriteLine("1. Create Account");
            Console.WriteLine("2. Login");
            Console.WriteLine("3. Exit");
            Console.Write("Choose an option: ");

            int choice = int.Parse(Console.ReadLine() ?? "0");

            switch (choice)
            {
                case 1:
                    bank.CreateAccount();
                    break;
                case 2:
                    var account = bank.Login();
                    if (account != null)
                    {
                        bool loggedIn = true;
                        while (loggedIn)
                        {
                            Console.WriteLine("\n--- ACCOUNT MENU ---");
                            Console.WriteLine("1. Deposit");
                            Console.WriteLine("2. Withdraw");
                            Console.WriteLine("3. Check Balance");
                            Console.WriteLine("4. Show Transaction History");
                            Console.WriteLine("5. Change Password");
                            Console.WriteLine("6. Add Interest");
                            Console.WriteLine("7. Logout");

                            int action = int.Parse(Console.ReadLine() ?? "0");

                            switch (action)
                            {
                                case 1:
                                    Console.Write("Enter amount to deposit: ");
                                    account.Deposit(decimal.Parse(Console.ReadLine() ?? "0"));
                                    break;
                                case 2:
                                    Console.Write("Enter amount to withdraw: ");
                                    account.Withdraw(decimal.Parse(Console.ReadLine() ?? "0"));
                                    break;
                                case 3:
                                    account.CheckBalance();
                                    break;
                                case 4:
                                    account.ShowTransactionHistory();
                                    break;
                                case 5:
                                    account.ChangePassword();
                                    break;
                                case 6:
                                    account.AddInterest();
                                    break;
                                case 7:
                                    loggedIn = false;
                                    break;
                                default:
                                    Console.WriteLine("Invalid option.");
                                    break;
                            }
                        }
                    }
                    break;
                case 3:
                    exit = true;
                    Console.WriteLine("Thank you for using our banking system!");
                    break;
                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }
        }
    }

}
