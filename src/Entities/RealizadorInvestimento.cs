using StrategyInvest.Interfaces;

namespace StrategyInvest.Entities
{
    public static class RealizadorInvestimento
    {
        private static readonly decimal PERCENTUAL_SEM_IMPOSTO = 0.75m;

        public static void Investir(ContaBancaria contaBancaria, decimal valorInvestimento, IInvestimento investimento)
        {
            // Saca o valor investido
            contaBancaria.Sacar(valorInvestimento);

            // Realiza o investimento
            investimento.Investir(valorInvestimento);

            // Soma o retorno do investimento com o percentual sem imposto
            valorInvestimento += investimento.Retorno * PERCENTUAL_SEM_IMPOSTO;

            // Deposita novamente na conta bancária
            contaBancaria.Depositar(valorInvestimento);
        }
    }
}
