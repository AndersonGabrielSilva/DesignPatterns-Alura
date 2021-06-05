using DesignPatterns.Strategy.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Strategy
{
    public class ICMS : Imposto
    {
        public ICMS() : base() { }
        public ICMS(Imposto imposto) : base(imposto) { }

        public override double Calcula(Orcamento orcamento)
        {
            var icms = orcamento.Valor * 0.1 + CalculoDoOutroImposto(orcamento);
            return icms;
        }
    }
}
