using DesignPatterns._6_Builder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            return new NotaFIscal (RazaoSocial, Cnpj, DataEmissao, valorTotal, impostos, Observacao, todosItens);
        }

    }
}
