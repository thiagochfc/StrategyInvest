using StrategyInvest.Exceptions;
using System;
using System.Text;

namespace StrategyInvest.Entities
{
    public class ContaBancaria
    {
        public string Titular { get; private set; }
        public decimal Saldo { get; private set; }

        public ContaBancaria(string titular, decimal saldo)
        {
            Titular = titular;
            Saldo = saldo;
        }

        public void Depositar(decimal deposito)
        {
            // Verifica se o depósito é menor ou igual a zero
            if (deposito <= 0.00m)
                throw new InvalidDepositoException($"O valor de depósito: {deposito} não pode ser menor ou igual a zero!");

            Console.WriteLine("********** DEPOSITANDO **********");
            Console.WriteLine($"VALOR: {deposito}");

            Saldo += deposito;
        }

        public void Sacar(decimal saque)
        {
            // Verifica se o saque é maior que o saldo
            if (saque > Saldo)
                throw new InvalidSaqueException($"O valor de saque: {saque} é superior ao saldo: {Saldo}!");

            // Verifica se o saque é menor ou igual a zero
            if (saque <= 0.00m)
                throw new InvalidSaqueException($"O valor de saque: {saque} não pode ser menor ou igual a zero!");

            Console.WriteLine("********** SACANDO **********");
            Console.WriteLine($"VALOR: {saque}");

            Saldo -= saque;
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine(string.Empty);
            sb.AppendLine("********** INFORMAÇÕES DA CONTA **********");
            sb.AppendLine($"Titular: {Titular}, Saldo disponível: {Saldo}");
            return sb.ToString();
        }
    }
}
