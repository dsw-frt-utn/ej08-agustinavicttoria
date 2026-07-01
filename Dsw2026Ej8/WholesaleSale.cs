using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej8
{
    internal class WholesaleSale : Sale
    {
        public WholesaleSale(decimal amount) : base(amount) { }

        public override decimal CalculateTotal()
        {
            return Amount * 0.90m;
        }
    }
}
