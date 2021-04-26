using System;
using System.Collections.Generic;
using System.Text;
using BankApp.Utility;
using BankApp.Exceptions;
using BankApp.Business;
using BankApp.Data_Layer;

namespace BankApp.Client
{
    internal class BankAccountController
    {
        public Constants Constant = new Constants();
        /// <summary>
        /// To access the functionality of an bank account. like-
        /// Withdraw, deposit, generate transaction history 
        /// and generate ministatement
        /// </summary>
        /// <param name="bankAccount"></param>
        public void ControlBankAccounts(BankAccount bankAccount)
        {
            BankAccount Account = bankAccount;
            //Message displaying the account details
            Console.WriteLine(Constant.OutputMessage, Account.AccountNumber, Account.GetMinimumBalance(), Account.CurrentBalance, Account.GetInterestRate(), Account.GetTheType());
            Console.WriteLine(Constant.MenuBankAccount);
            try
            {
               
                int Choice = int.Parse(Console.ReadLine());
                BankAccount BankAcount = bankAccount;
                switch (Choice)
                {
                    case 1:
                        //To withdraw amount
                        Console.WriteLine(Constant.EnterAmount);
                        Double WithdrawAmount = Convert.ToDouble(Console.ReadLine());
                        try
                        {
                            BankAcount.Withdraw(WithdrawAmount, BankAcount);
                            ControlBankAccounts(BankAcount);//updating account details
                        }
                        catch(MinimumBalanceRuleViolated e)
                        {
                            //When Current Balance goes below required minimum balance
                            Console.WriteLine(e.Message);
                        }
                        break;
                    case 2:
                        //To deposit Amount
                        Console.WriteLine(Constant.EnterAmount);
                        Double DepositAmount = Convert.ToDouble(Console.ReadLine());
                        BankAcount.Deposit(DepositAmount,BankAcount);//updating account details
                        ControlBankAccounts(BankAcount);
                        break;
                    case 3:
                        //to get transaction history
                        List<Transaction> Transactions = BankAcount.GetTransactionHistory();//getting the trnsaction list
                        foreach (Transaction TransactionHistory in Transactions)
                        {
                            Console.WriteLine(Constant.TransactionDetails, TransactionHistory.Amount, TransactionHistory.Type, TransactionHistory.TransactionID);
                        }
                        ControlBankAccounts(BankAcount);
                        break;
                    case 4:
                        List<Transaction> MiniTransactions = BankAcount.GetMiniStatement();
                        foreach (Transaction TransactionMini in MiniTransactions)
                        {
                            //Writing transaction list on console
                            Console.WriteLine(Constant.TransactionDetails, TransactionMini.Amount, TransactionMini.Type, TransactionMini.TransactionID);
                        }
                        ControlBankAccounts(BankAcount);
                        break;
                    default:
                        //when any other int is passed
                        break;
                }
            }
            catch
            {
                Console.WriteLine(Constant.InvalidInput);
            }

        }

    }
}

