using StrategyInvest.Interfaces;

namespace StrategyInvest.Entities
{
    public class InvestimentoConservador : IInvestimento
    {
        private static readonly decimal PERCENTUAL_RETORNO = 0.008m;
        private decimal _retorno;
        public decimal Retorno => _retorno;

        public void Investir(decimal valor) 
            => _retorno = valor * PERCENTUAL_RETORNO;
    }
}
