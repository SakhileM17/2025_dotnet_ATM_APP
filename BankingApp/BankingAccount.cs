using System;

namespace BankingAppFeatures
{
    public class BankAccount
    {

        private string accountHolderName;
        private string accountHolderSurname;
        private string accountHolderAccountNumber;

        private string accountHolderAccountType;
        private decimal balance;

        public BankAccount(decimal initialBalance, string name, string surname, string accountNumber, string accountType)
        {
            this.balance = initialBalance;
            this.accountHolderName = name;
            this.accountHolderSurname = surname;
            this.accountHolderAccountNumber = accountNumber;
            this.accountHolderAccountType = accountType;

        }

        //
        public string fullName => $"{accountHolderName} {accountHolderSurname}";

        public void showUserDetails()
        {
            Console.WriteLine($" -------------- Account Details ---------------");
            Console.WriteLine($"Full Name : {fullName}");
            Console.WriteLine($"Account Number : {accountHolderAccountNumber}");
            Console.WriteLine($"Account Type : {accountHolderAccountType}");
        }


        // Shows user account balance
        public void showUserBalance()
        {
            Console.WriteLine($"--------------- Financial Statement ---------------");
            Console.WriteLine($"Account Balance : R {balance}");
        }

        public void depositFunds(decimal amount)
        {
            if (amount > 0)
            {
                balance += amount;
                Console.WriteLine($"Success! R {amount} successfully deposited into account! ");
            }
            else
            {
                Console.WriteLine($"Ooops! Please Try again later!");
            }
        }

        public void withdrawFunds(decimal amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("Ooops! Please enter a valid amount");
            }
            else if (amount > balance)
            {
                Console.WriteLine($"Ooops! Insuffieffcient funds!");
            }
            else
            {
                balance -= amount;
                Console.WriteLine($"Transaction Successul! Withdrew R {amount}, Account Balance R {balance}");
            }
        }
    }
    
}