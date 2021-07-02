using DesignPatterns._6_Builder;
using System;

namespace DesignPatterns._7_Observer
{
    public class EnviadorDeSms : IAcaoAposCriarNota
    {
        public void Executa(NotaFIscal nf)
        {
            Console.WriteLine("Envia Por Sms");
        }
    }
}
