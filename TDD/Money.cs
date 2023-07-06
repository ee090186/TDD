using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDD
{
    public class Money : IExpression
    {
        public int amount;
        public string Currency { get; protected set; }
        public Money(int amount, string currency)
        {
            this.amount = amount;
            Currency = currency;
        }
        public IExpression Times(int multiplier)
        {
            return new Money(amount * multiplier, Currency);
        }
        public override Boolean Equals(object obj)
        {
            var money = (Money)obj;
            return amount == money.amount 
                && Currency.Equals(money.Currency);
        }

        public IExpression Plus(IExpression addend)
        {
            return new Sum(this, addend);
        }

        public Money Reduce(Bank bank, string to)
        {
            int rate = bank.Rate(Currency, to);
            return new Money(amount / rate, to);
        }
        public static Money Dollar(int amount) => new Money(amount, "USD");
        public static Money Franc(int amount) => new Money(amount, "CHF");
    }
}
