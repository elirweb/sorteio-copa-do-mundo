using SorteioCopaDoMundo.Domain.Comum;
using System;

namespace SorteioCopaDoMundo.Domain.Entidades
{
    public class Grupos: Base
    {
        public Selecoes Selecoes { get; set; }
        public char Potes { get; set; }
        public TimeSpan Horarios { get; set; }

        public Grupos(Grupos grupos)
        {

        }
        //Calculo de potes
        // Sortear grupos
        // Sortear jogos
       // Selecoes com mas pontuações no ranking da FIFA
    }
}
