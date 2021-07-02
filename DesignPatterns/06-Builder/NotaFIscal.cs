using System;
using System.Collections.Generic;

namespace DesignPatterns._6_Builder
{
    public class NotaFIscal
    {
        #region Construtor
        public NotaFIscal(string razaoSocial, string cnpj, DateTime dataDeEmissao1, double valorTotal, double impostos, string observacoes, IList<ItemDaNota> itens)
        {
            RazaoSocial = razaoSocial;
            Cnpj = cnpj;
            DataDeEmissao1 = dataDeEmissao1;
            ValorTotal = valorTotal;
            Impostos = impostos;
            Observacoes = observacoes;

            Itens = itens;
        }
        #endregion

        public string RazaoSocial { get; set; }
        public string Cnpj { get; set; }
        public DateTime DataDeEmissao1 { get; set; }
        public double ValorTotal { get; set; }
        public double Impostos { get; set; }
        public IList<ItemDaNota> Itens { get; set; }
        public string Observacoes { get; set; }

    }
}
