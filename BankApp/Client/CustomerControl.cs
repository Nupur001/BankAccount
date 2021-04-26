using System;
using System.Collections.Generic;
using System.Text;
using BankApp.Data_Layer;
using BankApp.Utility;
using BankApp.Business;
namespace BankApp.Client
{
    internal class CustomerControl
    {
        public Constants Constant = new Constants();
        public HeadOfficeControl HeadControl = new HeadOfficeControl();
        /// <summary>
        /// Menu to access Customer class functionalities like getting bank account and/or PAN number
        /// </summary>
        /// <param name="customer"></param>
        public void ControlCustomers(Customer customer)
        {
            Customer Customer1 = customer;
            Console.WriteLine(Constant.MenuCustomerControl);
            try
            {
                int Choice = int.Parse(Console.ReadLine());
                switch (Choice)
                {
                    case 1:
                        //Getting the list of all bank account of the particular customer
                            List<BankAccount> Accounts = Customer1.GetBankAccount();
                        //Then writing on console
                            foreach (BankAccount account in Accounts)
                            {
                                Console.WriteLine(Constant.OutputMessage, account.AccountNumber, account.GetMinimumBalance(), account.CurrentBalance, account.GetInterestRate(), account.GetTheType());

                            }
                            ControlCustomers(Customer1);
                        break;
                    case 2:
                        //Getting the pan number of customer and writing it on console
                            string PanNumber = Customer1.GetPanNumber();
                            Console.WriteLine(PanNumber);
                            ControlCustomers(Customer1);
                       
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

