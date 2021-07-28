using StrategyInvest.Entities;
using StrategyInvest.Exceptions;
using Xunit;

namespace StrategyInvest.Test
{
    public class ContaBancariaTest
    {
        [Fact]
        public void Saldo_Inicial_0_Depositar_500_Deve_Retornar_Deposito()
        {
            var contaBancaria = ContaBancariaFactory.Criar(0.00m);
            contaBancaria.Depositar(500.00m);
            Assert.Equal(500.00m, contaBancaria.Saldo);
        }

        [Theory]
        [InlineData(0.00)]
        [InlineData(-15.00)]
        public void Depositar_Negativo_Ou_0_Deve_Deve_Retornar_Exception(decimal deposito)
        {
            var contaBancaria = ContaBancariaFactory.Criar(0.00m);
            var expectedException = Assert.Throws<InvalidDepositoException>(() => contaBancaria.Depositar(deposito));
            Assert.IsType<InvalidDepositoException>(expectedException);
        }

        [Theory]
        [InlineData(200.00, 300.00, 500.00)]
        [InlineData(0.00, 150.00, 150.00)]
        [InlineData(2000.00, 150.00, 2150.00)]
        [InlineData(4200.50, 989.33, 5189.83)]
        public void Depositar_Deve_Somar_Saldo(decimal saldo, decimal deposito, decimal expected)
        {
            var contaBancaria = ContaBancariaFactory.Criar(saldo);
            contaBancaria.Depositar(deposito);
            Assert.Equal(expected, contaBancaria.Saldo);
        }

        [Theory]
        [InlineData(500.00, 500.00)]
        [InlineData(700.00, 700.00)]
        public void Sacar_Saldo_Deve_Retornar_0(decimal saldo, decimal saque)
        {
            var contaBancaria = ContaBancariaFactory.Criar(saldo);
            contaBancaria.Sacar(saque);
            Assert.Equal(0.00m, contaBancaria.Saldo);
        }

        [Theory]
        [InlineData(200.00, 500.00)]
        [InlineData(500.00, 700.00)]
        public void Sacar_Maior_Saldo_Disponivel_Deve_Retornar_Exception(decimal saldo, decimal saque)
        {
            var contaBancaria = ContaBancariaFactory.Criar(saldo);
            var expectedExcpetion = Assert.Throws<InvalidSaqueException>(() => contaBancaria.Sacar(saque));
            Assert.IsType<InvalidSaqueException>(expectedExcpetion);
        }

        [Theory]
        [InlineData(200.00, 0.00)]
        [InlineData(500.00, -15.00)]
        public void Sacar_Negativo_Ou_0_Deve_Deve_Retornar_Exception(decimal saldo, decimal saque)
        {
            var contaBancaria = ContaBancariaFactory.Criar(saldo);
            var expectedExcpetion = Assert.Throws<InvalidSaqueException>(() => contaBancaria.Sacar(saque));
            Assert.IsType<InvalidSaqueException>(expectedExcpetion);
        }
    }
}
