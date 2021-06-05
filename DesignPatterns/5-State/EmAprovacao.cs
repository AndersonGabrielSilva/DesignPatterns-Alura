using DesignPatterns._5_State.Enum;
using DesignPatterns._5_State.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns._5_State
{
    public class EmAprovacao : IEstadoDeUmOrcamento
    {
        public void AplicaDescontoExtra(Orcamento orcamento)
        {
                orcamento.Valor = orcamento.Valor - (orcamento.Valor * 0.05);
        }

        public void Aprova(Orcamento orcamento)
        {
            orcamento.StatusAtual = new Aprovado();
        }

        public void Reprova(Orcamento orcamento)
        {
            orcamento.StatusAtual = new Reprovado();
        }
      
        public void Finaliza(Orcamento orcamento)
        {
            throw new Exception("Orçamento em aprovação não pode ser finalizado!");
        }

    }
}
