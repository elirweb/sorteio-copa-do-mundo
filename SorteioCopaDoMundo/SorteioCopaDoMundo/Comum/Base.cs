using System;
using System.Collections.Generic;
using System.Text;

namespace SorteioCopaDoMundo.Domain.Comum
{
    public class Base
    {
        public int Id { get; set; }
        public DateTime Criacao { get; set; }
        public int Activo { get; set; }
    }
}
