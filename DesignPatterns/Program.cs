using DesignPatterns._2_ChainOfResponsibility;
using DesignPatterns._3_TemplateMethod;
using DesignPatterns.Strategy;
using DesignPatterns.Strategy.Interface;
using System;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            //Strategy();

            //Cadeia de Responsabilidades
            //ChainOfResponsibility();

            //Utilizado quando os metodos são Parecidos
            //TemplateMethod();

            //Decorator
            //Decorator();

            State();

            Console.ReadKey();
        }



        //Strategy
        private static void Strategy()
        {
            Imposto iss = new ISS();
            Imposto icms = new ICMS();

            Orcamento orcamento = new Orcamento(500);
            CalculadorDeImpostos calculador = new CalculadorDeImpostos();

            calculador.RealizaCalculo(orcamento, iss);
            calculador.RealizaCalculo(orcamento, icms);
        }

        /// <summary>
        /// Utilizado quando existe diversas regras de negocio mais nem todas devem ser aplicadas, depende da regra de cada uma
        /// </summary>
        private static void ChainOfResponsibility()
        {
            CalculadorDeDescontos calculador = new CalculadorDeDescontos();

            Orcamento orcamento = new Orcamento(500.0);

            orcamento.AdicionaItem(new Item("Refrigerante", 250));
            orcamento.AdicionaItem(new Item("Refrigerante2", 250));
            orcamento.AdicionaItem(new Item("Refrigerante2", 250));

            double desconto = calculador.Calcula(orcamento);

            Console.WriteLine(desconto);
        }

        //Template Method com Compartamentos Compostos /" Decorator"
        //Onde apos aplicr um imposto aplica outro que recebe por parametro
        private static void TemplateMethod()
        {
            //Foi criado apenas a Classe de Template de Impostos
            //Semelhante a Base Aplicação do Agro
        }

        //Utilizado quando um objeto precisa fazer muita coisa, 
        private static void Decorator()
        {
            Imposto iss = new ISS(new ICMS(new ICPP()));

            Orcamento orcamento = new Orcamento(500.0);

            double valor = iss.Calcula(orcamento);

            Console.WriteLine(valor);
        }


        private static void State()
        {
            Orcamento reforma = new Orcamento(500);

            Console.WriteLine(reforma.Valor);

            reforma.AplicaDescontoExtra();
            Console.WriteLine(reforma.Valor);

            reforma.Aprova();

            reforma.AplicaDescontoExtra();
            Console.WriteLine(reforma.Valor);

            reforma.Finaliza();

            reforma.AplicaDescontoExtra();
        }

    }
}
