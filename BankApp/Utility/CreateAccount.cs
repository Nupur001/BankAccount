using System;
using System.Collections.Generic;
using System.Text;
using BankApp.Business;
using BankApp.Exceptions;
using BankApp.Data_Layer;

namespace BankApp.Utility
{
    internal class CreateAccount
    {
        public Constants Constant = new Constants();
        /// <summary>
        /// Creates a bank account in the given branch
        /// </summary>
        /// <param name="panNumber"></param>
        /// <param name="type"></param>
        /// <param name="amount"></param>
        public void CreateBankAcccount(string panNumber, string type, double amount)
        {
            if ((type == "1") && (amount < 10000))
            {
                throw (new MinimumBalanceRuleViolated(Constant.MinimumBalance));
            }
            else if ((type == "2") && (amount < 20000))
            {
                throw (new MinimumBalanceRuleViolated(Constant.MinimumBalance));
            }

            if (!Branch.Customers.Exists(customer => customer.PanNumber == panNumber))
            {
                Customer Customer1 = new Customer();
                Customer1.PanNumber = panNumber;
                Branch.Customers.Add(Customer1);
            }

            Customer DesiredCustomer = Branch.Customers.Find(customer => customer.PanNumber == panNumber);


            if (type == "1")
            {
                BankAccount Account = new SavingsAccount();
                Account.CurrentBalance = amount;
                Account.AccountNumber = (Branch.BankAccounts.Count + 1).ToString();
                Branch.BankAccounts.Add(Account);
                Customer.Accounts.Add(Account);
                Console.WriteLine(Constant.AccountCreated, Account.AccountNumber);
            }
            else if (type == "2")
            {
                BankAccount Account = new CurrentAccount();
                Account.CurrentBalance = amount;
                Account.AccountNumber = (Branch.BankAccounts.Count + 1).ToString();
                Branch.BankAccounts.Add(Account);
                Customer.Accounts.Add(Account);
                Console.WriteLine(Constant.AccountCreated, Account.AccountNumber);
            }
            else
            {
                Console.WriteLine(Constant.InvalidInput);
            }


        }
    }
}
