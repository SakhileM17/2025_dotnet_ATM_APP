using System;
using BankingApp.Services;


namespace BankingApp.core
{
    public static class AppStarter
    {
        public static void Start()
        {
            //
            Console.Clear();
            Console.WriteLine("---------------- EKQI Banking Console Banking App ------------");

            //
            Console.WriteLine("Welcome to EKQi Bank Digital Experience, All your banking needs in one place.");

            var loginServices = new LoginServices();
            bool isLoggedIn = loginServices.Login();

            if (isLoggedIn)
            {

                Console.WriteLine(" ------------- EKQI Services ------------");
            }
            else
            {
                Console.WriteLine("Exiting Application. Have a Greate Day.");
            }
        }
    }
}