using DesignPatterns.Strategy.Interface;

namespace DesignPatterns.Strategy
{
    public class ISS : Imposto
    {
        public ISS() : base() { }

        public ISS(Imposto imposto) : base(imposto) { }

        public override double Calcula(Orcamento orcamento)
        {
            var iss = orcamento.Valor * 0.6 + CalculoDoOutroImposto(orcamento);

            return iss;
        }
    }
}
