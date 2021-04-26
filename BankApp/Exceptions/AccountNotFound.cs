using System;
using System.Collections.Generic;
using System.Text;

namespace BankApp.Exceptions
{
    //When Account is not found in the Accounts List
    public class AccountNotFound:Exception
    {
        public AccountNotFound(string message) : base(message)
        {

        }
    }
}
