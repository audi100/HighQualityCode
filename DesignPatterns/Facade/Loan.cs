using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Facade
{
    class Loan
    {
        public bool HasNoBadLoans(Customer customer)
        {
            Console.WriteLine("Check loans for " + customer.Name);

            return true;
        }
    }
}
