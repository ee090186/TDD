using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDD
{
    public class Franc : Money
    {
        public Franc(int amount)
        {
            this.amount = amount;
        }

        public override Money Times(int multiplier)
        {
            return new Franc(amount * multiplier);
        }

        public override string Currency() => "CHF";

    }

}
