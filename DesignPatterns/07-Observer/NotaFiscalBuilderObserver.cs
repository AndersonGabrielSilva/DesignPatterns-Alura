using DesignPatterns._6_Builder;
using System;
using System.Collections.Generic;

namespace DesignPatterns._7_Observer
{
    public class NotaFiscalBuilderObserver
    {
        public string RazaoSocial { get; private set; }
        public string Cnpj { get; private set; }
        public string Observacao { get; private set; }
        private double valorTotal;
        private double impostos;
        public DateTime DataEmissao { get; private set; }

        private IList<ItemDaNota> todosItens = new List<ItemDaNota>();

        private IList<IAcaoAposCriarNota> todasAcoesASeremExecutadas = new List<IAcaoAposCriarNota>();

        #region Metodos Builder
        public NotaFiscalBuilderObserver ParaEmpresa(string razaoSocial)
        {
            this.RazaoSocial = razaoSocial;
            return this;
        }

        public NotaFiscalBuilderObserver ComCnpj(string cnpj)
        {
            this.Cnpj = cnpj;
            return this;
        }

        public NotaFiscalBuilderObserver ComItem(ItemDaNota item)
        {
            todosItens.Add(item);
            valorTotal += item.Valor;
            impostos += item.Valor * 0.05;

            return this;
        }

        public NotaFiscalBuilderObserver ComObservacao(string observacao)
        {
            this.Observacao = observacao;

            return this;
        }

        public NotaFiscalBuilderObserver NaDataAtual()
        {
            DataEmissao = DateTime.Now;

            return this;
        }

        public NotaFIscal Constroi()
        {
            var nf = new NotaFIscal(RazaoSocial, Cnpj, DataEmissao, valorTotal, impostos, Observacao, todosItens);

            #region Acoes realizadas apos gerar Nota
            foreach (IAcaoAposCriarNota acao in todasAcoesASeremExecutadas)
            {
                acao.Executa(nf);
            }
            #endregion

            return nf;
        }
        #endregion

        #region Metodos Observer
        public NotaFiscalBuilderObserver AdicionaAcao(IAcaoAposCriarNota novaAcao)
        {
            this.todasAcoesASeremExecutadas.Add(novaAcao);

            return this;
        }
        #endregion

    }
}
