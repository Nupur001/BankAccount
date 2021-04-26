using System;
using System.Collections.Generic;
using System.Text;
using BankApp.Business;

namespace BankApp.Data_Layer
{
    internal class Customer
    {
        public string PanNumber { get; set; }
        //used to identify customers uniquely
        public static List<BankAccount> Accounts = new List<BankAccount>(); 
        //It is a list of the bank accounts (BankAccount) that are owned by customers.
        /// <summary>
        /// Returns all the bank accounts
        /// </summary>
        /// <returns></returns>
        public List<BankAccount> GetBankAccount()
        {
            return Accounts;
        }
        /// <summary>
        /// Returns PAN number of customer
        /// </summary>
        /// <returns></returns>
        public string GetPanNumber()
        {
            return PanNumber;   
        }
    }
}
