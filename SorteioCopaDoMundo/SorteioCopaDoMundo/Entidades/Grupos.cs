using System;
using System.Collections.Generic;
using System.Text;

namespace SorteioCopaDoMundo.Domain.Entidades
{
    public class Grupos
    {
        public Selecoes Selecoes { get; set; }
        public char Potes { get; set; }
        public Grupos(Grupos grupos)
        {
            Selecoes = grupos.Selecoes;
            Potes = grupos.Potes;
        } 
    }
}
