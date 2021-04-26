using System;
using System.Collections.Generic;
using BankApp.Business;
using BankApp.Client;
namespace BankApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            HeadOfficeControl HeadOffice = new HeadOfficeControl();
            HeadOffice.TakeChoice();
        }
    }
}
