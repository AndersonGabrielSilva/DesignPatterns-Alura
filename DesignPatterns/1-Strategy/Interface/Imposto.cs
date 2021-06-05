using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Strategy.Interface
{

    public abstract class Imposto
    {
        public Imposto OutroImposto { get; set; }

        public Imposto()
        {
            this.OutroImposto = null;
        }

        public  Imposto(Imposto outroImposto)
        {
            OutroImposto = outroImposto;
        }

        public abstract double Calcula(Orcamento orcamento);

        protected  double CalculoDoOutroImposto(Orcamento orcamento)
        {
            if (OutroImposto == null) return 0;

           return OutroImposto.Calcula(orcamento);
        }
    }
}
