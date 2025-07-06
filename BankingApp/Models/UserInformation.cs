/* Models - User Information. 

Purpose : Used to store user details. 

 */

using System;
using System.Dynamic;
using System.Reflection.Metadata.Ecma335;

namespace BankingApp.Models
{
    public class UserInformation
    {
        public string UserName { get; set; }
        public string UserSurname { get; set; }
        public string UserPin { get; set; }
        public decimal UserBalance { get; set; }

        public string UserAccountType { get; set; }

        public UserInformation(string name, string surname, string pin, decimal balance, string accountType)
        {
            UserName = name;
            UserSurname = surname;
            UserPin = pin;
            UserBalance = balance;
            UserAccountType = accountType;
        }


        public string GetFullName()
        {
            return $"{UserName} {UserSurname}";
        }

        //
        public void ShowUserDetails()
        {
            Console.WriteLine($"Name : {GetFullName()}");
            Console.WriteLine($"Account Type {UserAccountType}");
            Console.WriteLine($"Balance : R{UserBalance}");
        }
    }
}