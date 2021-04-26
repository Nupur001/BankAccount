using System;
using System.Collections.Generic;
using System.Text;

namespace BankApp.Exceptions
{
    //When current balance is about to go below Minimum Balance
    //i.e. at the time of account creation
    //or withdrawal from bank account
    public class MinimumBalanceRuleViolated : Exception
    {
        public MinimumBalanceRuleViolated(string message) : base(message)
        {
        }
    }
}

