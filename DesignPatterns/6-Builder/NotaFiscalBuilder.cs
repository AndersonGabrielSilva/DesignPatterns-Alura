using System;
using System.Collections.Generic;

namespace DesignPatterns._6_Builder
{
    public class NotaFiscalBuilder
    {
        public string RazaoSocial { get; private set; }
        public string Cnpj { get; private set; }
        public string Observacao { get; private set; }
        private double valorTotal;
        private double impostos;
        public DateTime DataEmissao { get; private set; }

        private IList<ItemDaNota> todosItens = new List<ItemDaNota>();


        public NotaFiscalBuilder ParaEmpresa(string razaoSocial)
        {
            this.RazaoSocial = razaoSocial;
            return this;
        }

        public NotaFiscalBuilder ComCnpj(string cnpj)
        {
            this.Cnpj = cnpj;
            return this;
        }

        public NotaFiscalBuilder ComItem(ItemDaNota item)
        {
            todosItens.Add(item);
            valorTotal += item.Valor;
            impostos += item.Valor * 0.05;

            return this;
        }

        public NotaFiscalBuilder ComObservacao(string observacao)
        {
            this.Observacao = observacao;

            return this;
        }

        public NotaFiscalBuilder NaDataAtual()
        {
            DataEmissao = DateTime.Now;

            return this;
        }

        public NotaFIscal Constroi()
        {
            return new NotaFIscal(RazaoSocial, Cnpj, DataEmissao, valorTotal, impostos, Observacao, todosItens);
        }

    }
}
