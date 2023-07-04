using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDD
{
    public class Bank
    {
        private Dictionary<Pair, int> Rates = new Dictionary<Pair, int>();
        public Money Reduce(IExpression source, String to)
        {
            return source.Reduce(this, to);
        }

        public void AddRate(string from, string to, int rate)
        {
            Rates.Add(new Pair(from, to), rate);
        }

        public int Rate(string from, string to)
        {
            if (from.Equals(to)) return 1;

            return Rates[new Pair(from, to)];
        }
    }
}
