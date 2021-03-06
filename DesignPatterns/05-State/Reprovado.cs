using DesignPatterns._5_State.Interface;
using System;

namespace DesignPatterns._5_State
{
    public class Reprovado : IEstadoDeUmOrcamento
    {
        public void AplicaDescontoExtra(Orcamento orcamento)
        {
            throw new Exception("Orçamentos reprovados não recebem desconto extra!");
        }

        public void Aprova(Orcamento orcamento)
        {
            throw new Exception("Orçamentos já está reprovado!");
        }

        public void Finaliza(Orcamento orcamento)
        {
            orcamento.StatusAtual = new Finalizado();
        }

        public void Reprova(Orcamento orcamento)
        {
            throw new Exception("Orçamentos já está reprovado");

        }
    }
}
