using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyInvest
{
    public static class Utils
    {
        public static int GetChances() => new Random().Next(101);
    }
}
