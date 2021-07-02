using DesignPatterns.Strategy.Interface;

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
