using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDD
{
    abstract public class Money
    {
        protected int amount;
        public abstract Money Times(int multiplier);
        public abstract string Currency();
        public override Boolean Equals(object obj)
        {
            var money = (Money)obj;
            return amount == money.amount 
                && GetType().Equals(money.GetType());
        }

        public static Money Dollar(int amount) => new Dollar(amount);
        public static Money Franc(int amount) => new Franc(amount);
    }
}
