using System;
using BankingAppFeatures;

namespace BankingApplication
{
    //
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to EKQi Finances");

            BankAccount myAccount = new BankAccount(5000, "Sakhile", "Mkhalele", "85656", "Cheque");

            myAccount.showUserDetails();
            myAccount.showUserBalance();
        }
    }
}