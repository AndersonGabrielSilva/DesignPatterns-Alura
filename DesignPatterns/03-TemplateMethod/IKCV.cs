using DesignPatterns.Strategy.Interface;

namespace DesignPatterns._3_TemplateMethod
{
    public class IKCV : TemplateDeImpostoCondicional
    {
        public IKCV() : base() { }
        public IKCV(Imposto imposto) : base(imposto) { }

        public override bool DeveUsarAMaximaTaxacao(Orcamento orcamento)
        {
            return orcamento.Valor > 500 && TemItemMaiorQue100ReaisNo(orcamento);
        }

        public override double MaximaTaxacao(Orcamento orcamento)
        {
            return orcamento.Valor * 0.01; ;
        }

        public override double MinimaTaxacao(Orcamento orcamento)
        {
            return orcamento.Valor * 0.06;
        }

        private bool TemItemMaiorQue100ReaisNo(Orcamento orcamento)
        {
            foreach (var item in orcamento.Itens)
            {
                if (item.Valor > 100)
                    return true;
            }

            return false;
        }
    }
}
