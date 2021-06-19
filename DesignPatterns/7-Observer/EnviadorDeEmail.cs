using DesignPatterns._6_Builder;
using System;

namespace DesignPatterns._7_Observer
{
    public class EnviadorDeEmail : IAcaoAposCriarNota
    {
        public void Executa(NotaFIscal nf)
        {
            Console.WriteLine("Envia Nota Fiscal Por Email");
        }
    }
}
