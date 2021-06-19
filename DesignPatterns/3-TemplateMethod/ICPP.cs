using DesignPatterns.Strategy.Interface;

namespace DesignPatterns._3_TemplateMethod
{
    public class ICPP : TemplateDeImpostoCondicional
    {
        public ICPP() : base() { }

        public ICPP(Imposto imposto) : base(imposto) { }

        public override bool DeveUsarAMaximaTaxacao(Orcamento orcamento)
        {
            return orcamento.Valor >= 500;
        }

        public override double MaximaTaxacao(Orcamento orcamento)
        {
            return orcamento.Valor * 0.07;
        }

        public override double MinimaTaxacao(Orcamento orcamento)
        {
            return orcamento.Valor * 0.05;
        }
    }
}
