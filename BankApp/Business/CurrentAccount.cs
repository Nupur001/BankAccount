using System;
using System.Collections.Generic;
using System.Text;

namespace BankApp.Business
{
    internal class CurrentAccount: BankAccount
    {
        /// <summary>
        /// Returns the type as "Current"
        /// </summary>
        /// <returns>type= "Current"</returns>
        public override string GetTheType()
        {
            return "Current";
        }
        /// <summary>
        /// Sets and returns the minimum Balance
        /// </summary>
        /// <returns>Minimum Balance</returns>
        public override double GetMinimumBalance()
        {
            MinimumBalance = 20000;
            return 20000;
        }
        /// <summary>
        /// Sets and returns Interest rate
        /// </summary>
        /// <returns>Get Interest Rate</returns>
        public override double GetInterestRate()
        {
            InterestRate = 0;
            return 0;
        }
    }
}
