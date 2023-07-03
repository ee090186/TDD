using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDD
{
    internal class Pair
    {
        private string From;
        private string To;
        public Pair(string from, string to)
        {
            From = from;
            To = to;
        }

        public override bool Equals(object? obj) 
        {
            var pair = (Pair)obj;
            return From.Equals(pair.From) && To.Equals(pair.To);
        }

        public override int GetHashCode()
        {
            return 0;
        }
    }
}
