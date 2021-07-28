using StrategyInvest.Entities;
using System;

namespace StrategyInvest
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var contaBancaria = new ContaBancaria("Thiago", 500.00m);
                contaBancaria.Depositar(1700.00m);
                Console.WriteLine(contaBancaria.ToString());
                contaBancaria.Sacar(200.00m);
                Console.WriteLine(contaBancaria.ToString());

                RealizadorInvestimento.Investir(contaBancaria, 2000.00m, new InvestimentoArrojado());
                Console.WriteLine(contaBancaria.ToString());
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro: {ex.Message}"); ;
            }
            
        }
    }
}
