using DesignPatterns._10_Memento;
using DesignPatterns._2_ChainOfResponsibility;
using DesignPatterns._3_TemplateMethod;
using DesignPatterns._6_Builder;
using DesignPatterns._7_Observer;
using DesignPatterns._8_Factory;
using DesignPatterns._9_Flyweight;
using DesignPatterns.Strategy;
using DesignPatterns.Strategy.Interface;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

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

            //State();

            //Builder();

            //Aprovaita o padrao builder
            //Observer();

            //Factory();

            //Utilizado para não criar varias intancias, do mesmo objeto. Cria apenas uma unica vez o objeto; 
            //Fleyweigh();

            //O Memento é utilizado sempre que necessitamos armazenar o estado de um elemento para ser possivel recuperar depois o mesmo estado
            Memento();

            Console.ReadKey();
        }

        private static void Memento()
        {
            var historicoContrato = new HistoricoContrato();

            var contrato = new Contrato("Anderson", DateTime.Now, TipoContrato.Novo);
            historicoContrato.Adiciona(contrato.SalvaEstado());

            contrato.Avanca();
            historicoContrato.Adiciona(contrato.SalvaEstado());

            contrato.Avanca();
            historicoContrato.Adiciona(contrato.SalvaEstado());

            contrato.Avanca();
            historicoContrato.Adiciona(contrato.SalvaEstado());

            Console.WriteLine(contrato.Tipo);

            Console.WriteLine(historicoContrato.Pega(TipoContrato.EmAndamento).Contrato.Tipo);
        }

        private static void Fleyweigh()
        {
            var notasMusicas = new NotasMusicais();

            IList<INota> musica = new List<INota>()
            {
                notasMusicas.GetNota("do"),
                notasMusicas.GetNota("re"),
                notasMusicas.GetNota("mi"),
                notasMusicas.GetNota("fa"),
                notasMusicas.GetNota("fa"),
                notasMusicas.GetNota("fa"),
                notasMusicas.GetNota("do"),
                notasMusicas.GetNota("re"),
                notasMusicas.GetNota("do"),
                notasMusicas.GetNota("re"),
                notasMusicas.GetNota("sol"),
                notasMusicas.GetNota("la"),
            };

            new Piano().Toca(musica);
        }

        private static void Factory()
        {
            IDbConnection connection = new ConnectionFactory().GetConnection();

            IDbCommand comando = connection.CreateCommand();
            comando.CommandText = "select*from tabela";
        }

        private static void Observer()
        {
            var criador = new NotaFiscalBuilderObserver();

            var notaFiscal = criador.ParaEmpresa("Alura Cursos Online")
                                    .ComCnpj("999.999.9999/99")
                                    .ComObservacao("Exemplo do padrão Builder")
                                    .NaDataAtual()
                                    .ComItem(new ItemDaNota("Curso de C#", 55.47))
                                    .ComItem(new ItemDaNota("Curso de Python", 60.45))
                                    .AdicionaAcao(new EnviadorDeEmail())
                                    .AdicionaAcao(new NotaFiscalDao())
                                    .AdicionaAcao(new EnviadorDeSms())
                                    .Constroi();
        }

        private static void Builder()
        {
            var criador = new NotaFiscalBuilder();

            var notaFiscal = criador.ParaEmpresa("Alura Cursos Online")
                                    .ComCnpj("999.999.9999/99")
                                    .ComObservacao("Exemplo do padrão Builder")
                                    .NaDataAtual()
                                    .ComItem(new ItemDaNota("Curso de C#", 55.47))
                                    .ComItem(new ItemDaNota("Curso de Python", 60.45))
                                    .Constroi();
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
