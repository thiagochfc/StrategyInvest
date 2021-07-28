using StrategyInvest.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyInvest.Test
{
    public class ContaBancariaFactory
    {
        public static ContaBancaria Criar(decimal valor)
        {
            return new ContaBancaria("Thiago", valor);
        }
    }
}
