using System;
using System.Collections.Generic;
using System.Text;
using BankApp.Utility;
using BankApp.Business;
using BankApp.Exceptions;
namespace BankApp.Client
{
    internal class BranchNavigation
    {
        public Constants Constant = new Constants();
        public HeadOfficeControl HeadControl = new HeadOfficeControl();
        /// <summary>
        /// Menu to navigate in a branch and provide access to functionalities like-
        /// creating bank account
        /// getting customer using pan number
        /// or getting account using account number
        /// </summary>
        /// <param name="branch"></param>
        public void Details(Branch branch)
        {
            Branch Branches = branch;
            Console.WriteLine(Constant.MenuBranchNavigation);
            try
            {
                int Choice = int.Parse(Console.ReadLine());
                var HeadOffic = new HeadOffice();
                switch (Choice)
                {
                    case 1:
                        //To create a new bank account
                        Console.WriteLine(Constant.EnterPan);
                        string PanNumber = Console.ReadLine();//Taking Pan Number as Input
                        Console.WriteLine(Constant.EnterType);
                        string Type = Console.ReadLine();//Taking the type as input
                        Console.WriteLine(Constant.EnterAmount);
                        double Amount = Convert.ToDouble(Console.ReadLine());//Taking amount as input
                        try
                        {
                            //creating the branch using input
                            Branches.CreateBankAcccount(PanNumber, Type, Amount);
                        }
                        catch(MinimumBalanceRuleViolated e)
                        {
                            //Exception handled when amount entered is less than minimum balance required
                            Console.WriteLine(e.Message);
                        }
                        Details(Branches);
                        break;
                    case 2:
                        //To get a customer using its pan
                        Console.WriteLine(Constant.EnterPan);
                        string PanNumber1 = Console.ReadLine();//Taking Pan as Input
                        try
                        {
                            Data_Layer.Customer Customer = Branches.GetCustomerByPan(PanNumber1);//getting the required customer returned
                            CustomerControl CustomerContro = new CustomerControl();
                            CustomerContro.ControlCustomers(Customer);//passing the customer to customer navigation/controller
                        }
                        catch(CustomerNotFound e)
                        {
                            //When such customer does not exist
                            Console.WriteLine(e.Message);
                        }
                        Details(Branches);
                        break;
                    case 3:
                        //To get an account
                        Console.WriteLine(Constant.EnterAccountNum);
                        string AccountNumber = Console.ReadLine();//Getting account number as input 
                        try
                        {
                            BankAccount Account = Branches.GetAccountByAccountNumber(AccountNumber);//getting account as return
                            BankAccountController BankControl = new BankAccountController();
                            BankControl.ControlBankAccounts(Account);//Passing the account to Bankaccount control to acess functionalities of the account
                        }
                        catch (AccountNotFound e)
                        {
                            //when account number does not exist
                            Console.WriteLine(e.Message);
                        }

                        Details(Branches);
                        break;
                    default:
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


