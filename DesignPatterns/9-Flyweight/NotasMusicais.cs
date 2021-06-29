using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns._9_Flyweight
{
    //Utilizado para não criar varias intancias, do mesmo objeto. Cria apenas uma unica vez o objeto; 
    public class NotasMusicais
    {
        private static IDictionary<string, INota> notas =
            new Dictionary<string, INota>()
            {
                {"do",new Do() },
                {"re",new Re() },
                {"mi",new Mi() },
                {"fa",new Fa() },
                {"sol",new Sol()},
                {"la",new La() },
                {"si",new Si() },
            };

        public INota GetNota(string nome)=>
            notas[nome];
        

    }
}
