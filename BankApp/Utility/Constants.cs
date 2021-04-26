using System;
using System.Collections.Generic;
using System.Text;

namespace BankApp.Utility
{
    public class Constants
    {
        
        public string HeadControlMenu = "Welcome To Head Branch!\n1.Press 1 to add a new Branch\n2.Press 2 to get a branch using its branchId\n3.Press 3 to get all the branches\n4.Press any other key to exit\nEnter your Choice";
        public string InvalidInput = "Input is not valid";
        public string TakeBranchId = "Enter the banch ID";
        public string TotalBankAccounts = "There are {0} BankAccounts in this Branch";
        public string TotalCustomers = "There are {0} Customers in this Branch";
        public string HitEnter = "Hit Enter To continue";
        public string BranchAdded = "Branch with branch Id {0} added";
        public string MenuBranchNavigation = "Welcome!\n1.Press 1 to create a bank account in this Branch\n2.Press 2 to Get Customer By PanNumber in this Branch\n3.Press 3 to Get Account By Account Number in this Branch\nPress any other key to exit\nEnter your choice";
        public string MenuCustomerControl = "Welcome!\n1.Press 1 to get all bank accounts of this customer\n2. Press 2 to get PanNumber of this Customer\n3.Any key to Exit\nEnter your choice- ";
        public string OutputMessage = "The Account Number is {0}\nThe minimum balance is {1}\nThe current balance is {2}\nThe Interest Rate is {3}\nAccount Type is {4}";
        public string MenuBankAccount = "Welcome!\n1.Press 1 to Withdraw\n2.Press 2 to Deposit\n3.Press 3 to get the list of all transactions\n4.Press 4 to get mini statement\n press any other key to exit";
        public string TransactionDetails="The transaction of amount - {0} was of type - {1} with transaction id - {2}" ;
        public string TransactionSuccess = "Transaction is successful\n";
        public string TransactionFailed = "Transaction Failed\n";
        public string Withdraw = "withdraw";
        public string Deposit = "deposit";
        public string AccountCreated = "Account Created Successfully with account number {0}";
        public string EnterPan = "Enter you PAN Number";
        public string EnterType = "Enter the Type of bank account you want \nPress 1 for Savings account\nPress 2 for Current account";
        public string EnterAmount = "Enter the amount";
        public string EnterAccountNum = "Enter the Account Number";
        public string NoCustomer = "This Customer Does not exist in the branch";
        public string NoAccount = "This Account Does not exist in the branch";
        public string NoBranch = "No Branch Here";
        public string MinimumBalance = "Minimum Balance rule is violated\nMinimum Balance for Savings account is 10000\nMinimum Balance for Current account is 20000\n\n";
    }
}
