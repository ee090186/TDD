﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDD
{
    public class Sum : IExpression
    {
        public Money Augend;
        public Money Addend;

        public Sum(Money augend, Money addend)
        {
            Augend = augend;
            Addend = addend;
        }

        public Money Reduce(string to)
        {
            var amount = Augend.amount + Addend.amount;
            return new Money(amount, to);
        }
    }
}
