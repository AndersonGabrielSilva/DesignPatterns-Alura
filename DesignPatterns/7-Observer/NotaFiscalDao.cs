using DesignPatterns._6_Builder;
using System;

namespace DesignPatterns._7_Observer
{
    public class NotaFiscalDao : IAcaoAposCriarNota
    {
        public void Executa(NotaFIscal nf)
        {
            Console.WriteLine("Salva Nota Fiscal no Banco");
        }
    }
}
