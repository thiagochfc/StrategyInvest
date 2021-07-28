using System;

namespace StrategyInvest.Exceptions
{
    public class InvalidSaqueException : Exception
    {
        public InvalidSaqueException(string message) : base(message) { }
    }
}
