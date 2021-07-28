using System;

namespace StrategyInvest.Exceptions
{
    public class InvalidDepositoException : Exception
    {
        public InvalidDepositoException(string message) : base(message) { }
    }
}
