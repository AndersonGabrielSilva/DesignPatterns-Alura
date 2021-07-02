namespace DesignPatterns._2_ChainOfResponsibility.Interface
{
    public interface IDesconto
    {
        IDesconto Proximo { get; set; }

        public double Desconto(Orcamento orcamento);
    }
}
