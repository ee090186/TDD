using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDD
{
    public class Franc
    {
        private int amount;
        public Franc(int amount)
        {
            this.amount = amount;
        }

        public Franc Times(int multiplier)
        {
            return new Franc(amount * multiplier);
        }

        public override Boolean Equals(object obj)
        {
            var franc = (Franc)obj;
            return amount == franc.amount;
        }
    }

}
