using DesignPatterns._2_ChainOfResponsibility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
   public class Orcamento
    {
        public double Valor { get; private set; }

        public IList<Item> Itens { get; private set; }

        public Orcamento(double Valor)
        {
            this.Valor = Valor;
            this.Itens = new List<Item>();
        }

        public void AdicionaItem(Item item)
        {
            Itens.Add(item);
        }
    }
}
