using SorteioCopaDoMundo.Domain.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace SorteioCopaDoMundo.Infra.Interfaces
{
    public interface IJogosRepository : Common.IRepository
    {
        Jogos Add(Jogos jogos);
    }
}
