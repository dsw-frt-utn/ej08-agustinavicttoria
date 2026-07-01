using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej8
{
    internal class Sale
    {
        public decimal Amount { get; set; }
        public Sale(decimal amount)
        {
            Amount = amount;
        }
        public virtual decimal CalculateTotal()
        {
            return Amount;
        }
    }
}
