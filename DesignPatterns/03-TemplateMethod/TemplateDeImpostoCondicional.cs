using DesignPatterns.Strategy.Interface;

namespace DesignPatterns._3_TemplateMethod
{
    public abstract class TemplateDeImpostoCondicional : Imposto
    {
        public TemplateDeImpostoCondicional() : base() { }
        public TemplateDeImpostoCondicional(Imposto imposto) : base(imposto) { }

        public override double Calcula(Orcamento orcamento)
        {
            if (DeveUsarAMaximaTaxacao(orcamento))
            {
                return MaximaTaxacao(orcamento);
            }

            return MinimaTaxacao(orcamento);
        }

        public abstract double MinimaTaxacao(Orcamento orcamento);

        public abstract double MaximaTaxacao(Orcamento orcamento);

        public abstract bool DeveUsarAMaximaTaxacao(Orcamento orcamento);
    }
}
