/*----------------- Login Functions --------------------------
 - The file is used for authentication
 */

using System;

namespace BankingApp.Services
{
    public class LoginServices
    {
        public bool Login()
        {
            int attempts = 3;

            while (attempts > 0)
            {
                // Step 1 - Requires the user to first input their 6 digit account number , followed by account pin.
                Console.WriteLine("Enter your 6 digit account number : ");
                string inputUserAccountNo = Console.ReadLine();

                if (inputUserAccountNo == "123456")
                {
                    // Step 2 - If Account number is correct , user will required to input their 4 digit pin.
                    Console.WriteLine("Enter your pin : ");
                    string inputUserPin = Console.ReadLine();

                    if (inputUserPin == "1234")
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Login Successful");
                        Console.ResetColor();
                        return true;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Ooops! Incorrect Pin ");
                        Console.ResetColor();
                        attempts--;
                        if (attempts > 0)
                        {
                            Console.WriteLine($"Attempts remaining: {attempts}");
                        }
                    }
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Ooppps - Incorrect Format! Only type 6 numbers");
                    Console.ResetColor();
                    attempts--;
                    if (attempts > 0)
                    {
                        Console.WriteLine($"Attempts remaining: {attempts}");
                    }
                }
            }

            Console.WriteLine("Too many failed attempts. Access denied.");
            return false;
        }
    }
}