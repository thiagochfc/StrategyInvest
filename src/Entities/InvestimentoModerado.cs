using StrategyInvest.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyInvest.Entities
{
    public class InvestimentoModerado : IInvestimento
    {
        private static readonly decimal PERCENTUAL_RETORNO_ALTO = 0.025m;
        private static readonly decimal PERCENTUAL_RETORNO_BAIXO = 0.007m;
        private static readonly decimal CINQUENTA_UM_PORCENTO = 50;
        private decimal _retorno;
        public decimal Retorno => _retorno;

        public void Investir(decimal valor) 
            => _retorno = Utils.GetChances() > CINQUENTA_UM_PORCENTO ? valor * PERCENTUAL_RETORNO_ALTO : valor * PERCENTUAL_RETORNO_BAIXO;
    }
}
