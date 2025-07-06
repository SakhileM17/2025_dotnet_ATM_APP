/* Models - Bank Account.  

Purpose: Shows the bank account information such as types available.
*/

using System;

namespace BankingApp.Models
{
    public static class BankAccountInformation
    {
        // List of supported account types
        public static readonly string[] AccountTypes = { "Cheque", "Transmission", "Savings" };
    }
}
