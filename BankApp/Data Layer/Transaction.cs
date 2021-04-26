using System;
using System.Collections.Generic;
using System.Text;

namespace BankApp.Data_Layer
{
    public class Transaction
    {
        /// <summary>
        /// It is a unique ID to identify the transactions that are made against a bank account.
        /// These IDs are assigned by the bank account.
        /// </summary>
        public string TransactionID { get; set; }
        /// <summary>
        /// It represents the transaction amount.
        /// </summary>
        public double Amount { get; set; }
        /// <summary>
        /// It contains the value withdraw or deposit depending on the type of transaction.
        /// </summary>
        public string Type { get; set; }


        /// <summary>
        /// Returns the transaction id
        /// </summary>
        /// <returns></returns>
        public string GetTransactionID()
        {
            return TransactionID;
        }
        /// <summary>
        /// Returns the Amount
        /// </summary>
        /// <returns></returns>
        public double GetAmount()
        {
            return Amount;
        }
        /// <summary>
        /// Return the type of transaction
        /// </summary>
        /// <returns></returns>
        public string GetTheType()
        {
            return Type;
        }
    }
}
