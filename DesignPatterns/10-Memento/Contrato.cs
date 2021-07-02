using System;

namespace DesignPatterns._10_Memento
{
    public class Contrato
    {
        #region Construtor
        public Contrato(string cliente, DateTime data, TipoContrato tipo)
        {
            Cliente = cliente;
            Data = data;
            Tipo = tipo;
        }
        #endregion


        public string Cliente { get; private set; }
        public DateTime Data { get; private set; }
        public TipoContrato Tipo { get; private set; }

        public void Avanca()
        {
            if (Tipo == TipoContrato.Novo) this.Tipo = TipoContrato.EmAndamento;
            else if (Tipo == TipoContrato.EmAndamento) this.Tipo = TipoContrato.Acertado;
            else if (Tipo == TipoContrato.Acertado) this.Tipo = TipoContrato.Concluido;
        }

        public Estado SalvaEstado()=>      
             new Estado(new Contrato(this.Cliente, this.Data,this.Tipo));
        
    }
}
