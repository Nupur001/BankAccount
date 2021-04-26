﻿using System;
using System.Collections.Generic;
using System.Text;
using BankApp.Data_Layer;
using BankApp.Utility;

namespace BankApp.Business
{
    abstract class BankAccount
    {
        /// <summary>
        /// It is a unique number that is used to identify the bank account in a branch.
        /// It is generated by the branch in which the account has been opened.
        /// </summary>
        public string AccountNumber { get; set; }
        /// <summary>
        /// It is the minimum amount that must always be available in the bank account. 
        /// </summary>
        public double MinimumBalance { get; set; }
        /// <summary>
        /// It is the current amount that is in the bank account.
        /// </summary>
        public double CurrentBalance { get; set; }
        /// <summary>
        /// It is the percentage of interest.
        /// </summary>
        public double InterestRate { get; set; }
        /// <summary>
        /// It is a list that contains all transactions that are associated with the bank account.
        /// The latest transaction is always added at the end of the list.
        /// </summary>
        public List<Transaction> Transactions=new List<Transaction>();
        /// <summary>
        /// Object of Constant class
        /// </summary>
        public Constants Constant = new Constants();

        /// <summary>
        /// It returns the list of transactions
        /// </summary>
        /// <returns></returns>
        public List<Transaction> GetTransactionHistory()
        {
            return Transactions;
        }
        /// <summary>
        /// It returns the last 10 transactions with the latest transaction at the end of the list.
        /// </summary>
        /// <returns></returns>
        public List<Transaction> GetMiniStatement()
        {
            if (Transactions.Count <= 10)
            {
                return Transactions;
            }
            else
            {
                List<Transaction> MiniTransaction = Transactions.GetRange(Transactions.Count - 10, 10);
                MiniTransaction.Reverse();
                return MiniTransaction;
            }
        }

        /// <summary>
        /// Withdraws the entered amount from the given bank account
        /// </summary>
        /// <param name="withdrawalAmount"></param>
        /// <param name="bankAccount"></param>
        public void Withdraw(Double withdrawalAmount, BankAccount bankAccount)
        {
            WithdrawAndDeposit Withdraw = new WithdrawAndDeposit();
            Withdraw.Withdraw(withdrawalAmount, bankAccount);
        }

        /// <summary>
        /// Deposits the given amount to the bank account
        /// </summary>
        /// <param name="depositAmount"></param>
        /// <param name="bankAccount"></param>
        public void Deposit(double depositAmount, BankAccount bankAccount)
        {
            WithdrawAndDeposit Deposit = new WithdrawAndDeposit();
            Deposit.Deposit(depositAmount, bankAccount);
        }

        /// <summary>
        /// Returns Current Balance
        /// </summary>
        /// <returns></returns>
        public double GetCurrentBalance()
        {
            return CurrentBalance;
        }

        public abstract double GetMinimumBalance();
        public abstract double GetInterestRate();
        public abstract string GetTheType();
    }
}