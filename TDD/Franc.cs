using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDD
{
    public class Franc : Money
    {
        public Franc(int amount, string currency)
        {
            this.amount = amount;
            Currency = currency;
        }

        public override Money Times(int multiplier)
        {
            return Money.Franc(amount * multiplier);
        }

    }

}
