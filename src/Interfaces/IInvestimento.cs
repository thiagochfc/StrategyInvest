using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyInvest.Interfaces
{
    public interface IInvestimento
    {
        public decimal Retorno { get; }
        public void Investir(decimal valor);
    }
}
