using System;
using System.Collections.Generic;
using System.Text;

namespace BankApp.Exceptions
{
    //When Customer is not found in the Customer List
    public class CustomerNotFound:Exception
    {
        public CustomerNotFound(string message) : base(message)
            {
            }
        
    }
}
