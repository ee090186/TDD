using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDD
{
    public class Money
    {
        protected int amount;
        public override Boolean Equals(object obj)
        {
            var money = (Money)obj;
            return amount == money.amount;
        }
    }
}
