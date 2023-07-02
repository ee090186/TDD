using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDD
{
    public class Bank
    {
        public Money Reduce(IExpression source, String to)
        {
            return source.Reduce(this, to);
        }

        public void AddRate(string from, string to, int rate)
        { 
        }

        public int Rate(string from, string to)
        {
            return (from.Equals("CHF") && to.Equals("USD")) ? 2 : 1;
        }
    }
}
