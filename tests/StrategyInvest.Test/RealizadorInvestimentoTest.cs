using StrategyInvest.Entities;
using StrategyInvest.Interfaces;
using Xunit;

namespace StrategyInvest.Test
{
    public class RealizadorInvestimentoTest
    {
        [Theory]
        [InlineData(2000, 1500, 2009)]
        [InlineData(5000, 5000, 5030)]
        [InlineData(50, 30, 50.18)]
        [InlineData(25, 10, 25.06)]
        public void Investimento_Conservador(decimal deposito, decimal valorInvestimento, decimal expected)
        {
            var tipoInvestimento = new InvestimentoConservador();
            var contaBancaria = ContaBancariaFactory.Criar(deposito);
            RealizadorInvestimento.Investir(contaBancaria, valorInvestimento, tipoInvestimento);
            Assert.Equal(expected, contaBancaria.Saldo);
        }
    }
}
