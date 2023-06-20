using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDD
{
    public class Dollar : Money
    {
        private int amount;
        public Dollar(int amount)
        {
            this.amount = amount;
        }

        public Dollar Times(int multiplier)
        {
            return new Dollar(amount * multiplier);
        }

        public override Boolean Equals(object obj)
        {
            var dollar = (Dollar)obj;
            return amount == dollar.amount;
        }
    }
}
