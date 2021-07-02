using DesignPatterns._2_ChainOfResponsibility.Interface;

namespace DesignPatterns._2_ChainOfResponsibility
{
    public class DescontoPorCincoItens : IDesconto
    {
        public IDesconto Proximo { get; set; }

        public double Desconto(Orcamento orcamento)
        {
            if (orcamento.Itens.Count > 5)
                return orcamento.Valor * 0.01;

            return Proximo.Desconto(orcamento);
        }
    }
}
