/*Applicaiton Core  

Purpose: Orchestrates the main application flow and user experience

 */

using System;
using BankingApp.Services;

namespace BankingApp.core
{
    public static class AppStarter
    {
        public static void Start()
        {
            Console.Clear();
            Console.WriteLine("---------------- EKQI Banking Console Banking App ------------");

            Console.WriteLine("Welcome to EKQi Bank Digital Experience, All your banking needs in one place.");

            // Remove the "new LoginServices()" part since Login() is now static
            bool isLoggedIn = LoginServices.Login();

            if (isLoggedIn)
            {
                Console.WriteLine(" ------------- EKQI Services ------------");
            }
            else
            {
                Console.WriteLine("Exiting Application. Have a Great Day.");
            }
        }
    }
}