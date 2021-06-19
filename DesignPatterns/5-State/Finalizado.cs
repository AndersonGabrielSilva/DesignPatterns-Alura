using DesignPatterns._5_State.Interface;
using System;

namespace DesignPatterns._5_State
{
    public class Finalizado : IEstadoDeUmOrcamento
    {
        public void AplicaDescontoExtra(Orcamento orcamento)
        {
            throw new Exception("Orçamentos reprovados não recebem desconto extra!");
        }

        public void Aprova(Orcamento orcamento)
        {
            throw new Exception("Orçamentos já está finalizado");
        }

        public void Finaliza(Orcamento orcamento)
        {
            throw new Exception("Orçamentos já está finalizado");
        }

        public void Reprova(Orcamento orcamento)
        {
            throw new Exception("Orçamentos já está finalizado");
        }
    }
}
