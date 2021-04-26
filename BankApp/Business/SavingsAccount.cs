using System;
using System.Collections.Generic;
using System.Text;

namespace BankApp.Business
{
    internal class SavingsAccount: BankAccount
    {
        /// <summary>
        /// Sets and Returns The minimum Balance
        /// </summary>
        /// <returns></returns>
        public override double GetMinimumBalance()
        {
            MinimumBalance = 10000;
            return 10000;
        }
        /// <summary>
        /// Sets and Returns the InterestRate
        /// </summary>
        /// <returns>InterestRate=4.5</returns>
        public override double GetInterestRate()
        {
            InterestRate = 4.5;
            return 4.5;
        }
        /// <summary>
        /// Returns the type of bank account i. e. Savings/Current
        /// </summary>
        /// <returns>"Saving"</returns>
        public override string GetTheType()
        {
            return "Savings";
        }
    }
}
