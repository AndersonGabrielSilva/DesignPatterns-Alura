using DesignPatterns._5_State.Enum;
using DesignPatterns._5_State.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns._5_State
{
    public class Aprovado : IEstadoDeUmOrcamento
    {
        public void AplicaDescontoExtra(Orcamento orcamento)
        {
                orcamento.Valor = orcamento.Valor - (orcamento.Valor * 0.02);
        }

        public void Aprova(Orcamento orcamento)
        {
            throw new Exception("Orçamento já está em aprovação");

        }

        public void Reprova(Orcamento orcamento)
        {
            throw new Exception("Orçamento já está em aprovação e não pode ser reprovado");
        }

        public void Finaliza(Orcamento orcamento)
        {
            orcamento.StatusAtual = new Finalizado();
        }
    }
}
