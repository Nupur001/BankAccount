using System;
using System.Collections.Generic;
using System.Text;
using BankApp.Business;
using BankApp.Exceptions;
using BankApp.Data_Layer;


namespace BankApp.Utility
{
    internal class WithdrawAndDeposit
    {
        public Constants Constant = new Constants();

        /// <summary>
        /// Withdraws the entered amount from the given bank account
        /// </summary>
        /// <param name="withdrawalAmount"></param>
        /// <param name="bankAccount"></param>
        public void Withdraw(Double withdrawalAmount, BankAccount bankAccount)
        {
            BankAccount BankAcc = bankAccount;
            //Balance is to hold the possible balance if amount is withdrawn
            double Balance = BankAcc.CurrentBalance - withdrawalAmount;

            //If the balance is greater than minimum balance, then the transaction should succeed
            if (Balance >= BankAcc.GetMinimumBalance())
            {
                BankAcc.CurrentBalance = Balance;//On transaction Successful
                //Updating Transactions list
                Transaction TransactionTemporary = new Transaction();
                TransactionTemporary.Amount = withdrawalAmount;
                TransactionTemporary.Type = Constant.Withdraw;
                TransactionTemporary.TransactionID = (BankAcc.Transactions.Count + 1).ToString();
                BankAcc.Transactions.Add(TransactionTemporary);//Adding to the transactions list
                Console.WriteLine(Constant.TransactionSuccess);
            }
            else//Transaction invalid
            {
                Console.WriteLine(Constant.TransactionFailed);
                throw (new MinimumBalanceRuleViolated(Constant.MinimumBalance));
            }
        }
        /// <summary>
        /// Deposits the given amount to the bank account
        /// </summary>
        /// <param name="depositAmount"></param>
        /// <param name="bankAccount"></param>
        public void Deposit(double depositAmount, BankAccount bankAccount)
        {
            var BankAcc = bankAccount;
            if (depositAmount > 0)
            {
                BankAcc.CurrentBalance += depositAmount;
                //Updating Transactions list
                Transaction TransactionTemporary = new Transaction();
                TransactionTemporary.Amount = depositAmount;
                TransactionTemporary.Type = Constant.Deposit;
                TransactionTemporary.TransactionID = (BankAcc.Transactions.Count + 1).ToString();
                BankAcc.Transactions.Add(TransactionTemporary);//Adding to the Transactions List
                Console.WriteLine(Constant.TransactionSuccess);
            }
            else
            {
                Console.WriteLine(Constant.TransactionFailed);
            }
        }
    }
}
