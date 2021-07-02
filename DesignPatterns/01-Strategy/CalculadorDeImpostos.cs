using DesignPatterns.Strategy.Interface;
using System;

namespace DesignPatterns.Strategy
{
    public class CalculadorDeImpostos
    {
        public void RealizaCalculo(Orcamento orcamento, Imposto imposto)
        {
            double vlrImposto = imposto.Calcula(orcamento);

            Console.WriteLine(vlrImposto);
        }
    }
}
