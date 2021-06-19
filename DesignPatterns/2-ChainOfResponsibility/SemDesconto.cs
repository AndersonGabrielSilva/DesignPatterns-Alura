using DesignPatterns._2_ChainOfResponsibility.Interface;

namespace DesignPatterns._2_ChainOfResponsibility
{
    public class SemDesconto : IDesconto
    {
        public IDesconto Proximo { get; set; }

        public double Desconto(Orcamento orcamento)
        {
            return 0;
        }
    }
}
