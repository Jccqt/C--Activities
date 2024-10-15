using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory
{
    internal class ExceptionClass
    {
    }

    class NumberFormatException : Exception
    {
        public NumberFormatException(string Quantity) : base(Quantity)
        {

        }
    }

    class StringFormatException : Exception
    {
        public StringFormatException(string ProductName) : base(ProductName)
        {

        }
    }

    class CurrencyFormatException : Exception
    {
        public CurrencyFormatException(string Currency) : base(Currency)
        {

        }
    }
}
