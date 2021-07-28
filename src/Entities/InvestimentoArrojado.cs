using StrategyInvest.Interfaces;

namespace StrategyInvest.Entities
{
    public class InvestimentoArrojado : IInvestimento
    {
        private static readonly decimal PERCENTUAL_RETORNO_ALTO = 0.05m;
        private static readonly decimal PERCENTUAL_RETORNO_MEDIO = 0.03m;
        private static readonly decimal PERCENTUAL_RETORNO_BAIXO = 0.006m;
        private decimal _retorno;
        public decimal Retorno => _retorno;

        public void Investir(decimal valor)
        {
            int chance = Utils.GetChances();
            decimal percentual;

            if (chance < 21)
                percentual = PERCENTUAL_RETORNO_ALTO;
            else if (chance < 51)
                percentual = PERCENTUAL_RETORNO_MEDIO;
            else
                percentual = PERCENTUAL_RETORNO_BAIXO;

            // Define o valor de retorno
            _retorno  = valor * percentual;
        }
    }
}
