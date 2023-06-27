using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDD
{
    public class Money : IExpression
    {
        protected int amount;
        public string Currency { get; protected set; }
        public Money(int amount, string currency)
        {
            this.amount = amount;
            Currency = currency;
        }
        public Money Times(int multiplier)
        {
            return new Money(amount * multiplier, Currency);
        }
        public override Boolean Equals(object obj)
        {
            var money = (Money)obj;
            return amount == money.amount 
                && Currency.Equals(money.Currency);
        }

        public IExpression Plus(Money addend)
        {
            return new Money(amount + addend.amount, Currency);
        }
        public static Money Dollar(int amount) => new Money(amount, "USD");
        public static Money Franc(int amount) => new Money(amount, "CHF");
    }
}
