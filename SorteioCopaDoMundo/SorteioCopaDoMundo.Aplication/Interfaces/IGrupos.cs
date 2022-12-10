using SorteioCopaDoMundo.Domain.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace SorteioCopaDoMundo.Aplication.Interfaces
{
    public interface IGrupos
    {
        Grupos Add(List<Selecoes> selecoes);
    }
}
