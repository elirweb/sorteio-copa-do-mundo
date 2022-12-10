using SorteioCopaDoMundo.Domain.Comum;
using System;

namespace SorteioCopaDoMundo.Domain.Entidades
{
    public class Jogos: Base
    {
        public Grupos Grupos { get; set; }
        public TimeSpan Horarios { get; set; }

        public Jogos(Jogos jogos)
        {
            Grupos = jogos.Grupos;
            Horarios = jogos.Horarios;
        }
        
    }
}
