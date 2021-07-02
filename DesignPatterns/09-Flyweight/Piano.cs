using System;
using System.Collections.Generic;

namespace DesignPatterns._9_Flyweight
{
    public class Piano
    {
        public void Toca(IList<INota> musicas)
        {
            foreach (var nota in musicas)
            {
                Console.Beep(nota.Frequencia, 250);
            }
        }
    }
}
