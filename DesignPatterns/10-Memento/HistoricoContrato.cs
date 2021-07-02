using System.Collections.Generic;
using System.Linq;

namespace DesignPatterns._10_Memento
{
    public class HistoricoContrato
    { 
        public IList<Estado> Estados = new List<Estado>();

        public void Adiciona(Estado estado)
        {
            this.Estados.Add(estado);
        }

        //recupera o estado do contrato de acordo com o Tipo de Contrato
        public Estado Pega(TipoContrato tipoContrato)
        {
            return this.Estados.FirstOrDefault(x => x.Contrato.Tipo == tipoContrato);
        }
    }
}
