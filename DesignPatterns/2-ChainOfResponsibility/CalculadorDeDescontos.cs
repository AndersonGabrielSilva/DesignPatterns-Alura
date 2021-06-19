using DesignPatterns._2_ChainOfResponsibility.Interface;

namespace DesignPatterns._2_ChainOfResponsibility
{
    public class CalculadorDeDescontos
    {
        public double Calcula(Orcamento orcamento)
        {
            #region Cria Descontos
            IDesconto d1 = new DescontoPorCincoItens();
            IDesconto d2 = new DescontoPorMaisDeQuinhentosReais();
            IDesconto d3 = new SemDesconto();
            #endregion

            #region Define a Cadeira de Responsabilidades
            d1.Proximo = d2;
            d2.Proximo = d3;
            #endregion

            return d1.Desconto(orcamento);
        }
    }
}
