﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDD
{
    public interface IExpression
    {
        Money Reduce(Bank bank, string to);
    }
}