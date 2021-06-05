using DesignPatterns._2_ChainOfResponsibility.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns._2_ChainOfResponsibility
{
    public class DescontoPorMaisDeQuinhentosReais : IDesconto
    {
        public IDesconto Proximo { get;  set; }

        public double Desconto(Orcamento orcamento)
        {
            if(orcamento.Valor >= 500)
            {
                return orcamento.Valor * 0.07;
            }

            return Proximo.Desconto(orcamento);
        }
    }
}
