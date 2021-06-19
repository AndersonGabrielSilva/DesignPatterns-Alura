using DesignPatterns._2_ChainOfResponsibility;
using DesignPatterns._5_State;
using DesignPatterns._5_State.Interface;
using System.Collections.Generic;

namespace DesignPatterns
{
    public class Orcamento
    {
        public double Valor { get; set; }

        public IEstadoDeUmOrcamento StatusAtual { get; set; }

        public IList<Item> Itens { get; private set; }

        public Orcamento(double Valor)
        {
            this.Valor = Valor;
            this.Itens = new List<Item>();
            this.StatusAtual = new EmAprovacao();
        }

        public void AdicionaItem(Item item)
        {
            Itens.Add(item);
        }

        public void AplicaDescontoExtra()
        {
            StatusAtual.AplicaDescontoExtra(this);
        }

        #region Status do Orçamento
        public void Aprova()
        {
            StatusAtual.Aprova(this);
        }

        public void Reprova()
        {
            StatusAtual.Reprova(this);
        }

        public void Finaliza()
        {
            StatusAtual.Finaliza(this);
        }
        #endregion
    }
}
