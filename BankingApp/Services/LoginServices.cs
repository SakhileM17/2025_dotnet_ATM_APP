/*Login Services. 

Purpose : Handles user authentication for the banking application

 */

using System;

namespace BankingApp.Services
{
    public class LoginServices
    {
        // Provides Authentciation services for banking application.
        public static bool Login()
        {
            int attempts = 3; // Used to track number of attempts , users can only have 3 attempts before being blocked.

            string attemptsRemainingWarning = "Attempts remaining:";
            string lastAttemptRemainingWarning = "This is yous your last attempt!!";

            while (attempts > 0)
            {
                // User only has 3 Attempts to input correct password

                // Step 1 - Requires the user to first input their 6 digit account number, followed by account pin.
                Console.WriteLine("Enter your 6 digit account number: ");
                string inputUserAccountNo = Console.ReadLine() ?? string.Empty;

                // Additional validation for account number format
                if (string.IsNullOrWhiteSpace(inputUserAccountNo))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Input cannot be empty. Please try again.");
                    Console.ResetColor();
                    attempts--;
                    if (attempts == 1)
                    {
                        Console.WriteLine($"{lastAttemptRemainingWarning} {attempts}");
                    }
                    else if (attempts > 0)
                    {
                        Console.WriteLine($"{attemptsRemainingWarning} {attempts}");
                    }
                    continue;
                }

                if (inputUserAccountNo == "123456")
                {
                    // Step 2 - If Account number is correct, user will required to input their 4 digit pin.
                    Console.WriteLine("Enter your pin: ");
                    string inputUserPin = Console.ReadLine() ?? string.Empty;

                    // Additional validation for pin
                    if (string.IsNullOrWhiteSpace(inputUserPin))
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("PIN cannot be empty. Please try again.");
                        Console.ResetColor();
                        attempts--;
                        if (attempts == 1)
                        {
                            Console.WriteLine($"{lastAttemptRemainingWarning} {attempts}");
                        }
                        else if (attempts > 0)
                        {
                            Console.WriteLine($"{attemptsRemainingWarning} {attempts}");
                        }
                        continue;
                    }

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
                        Console.WriteLine("Ooops! Incorrect Pin");
                        Console.ResetColor();
                        attempts--;
                        if (attempts == 1)
                        {
                            Console.WriteLine($"{lastAttemptRemainingWarning} {attempts}");
                        }
                        else if (attempts > 0)
                        {
                            Console.WriteLine($"{attemptsRemainingWarning} {attempts}");
                        }
                    }
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Ooppps - Incorrect Format! Only type 6 numbers");
                    Console.ResetColor();
                    attempts--;
                    if (attempts == 1)
                    {
                        Console.WriteLine($"{lastAttemptRemainingWarning} {attempts}");
                    }
                    else if (attempts > 0)
                    {
                        Console.WriteLine($"{attemptsRemainingWarning} {attempts}");
                    }
                }
            }

            Console.WriteLine("Too many failed attempts. Access denied.");
            return false;
        }
    }
}