using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDD
{
    public class Sum : IExpression
    {
        public IExpression Augend;
        public IExpression Addend;

        public Sum(IExpression augend, IExpression addend)
        {
            Augend = augend;
            Addend = addend;
        }

        public Money Reduce(Bank bank, string to)
        {
            var amount = Augend.Reduce(bank, to).amount
                       + Addend.Reduce(bank, to).amount;
            return new Money(amount, to);
        }

        public IExpression Plus(IExpression addend) => new Sum(this, addend);
    }
}
