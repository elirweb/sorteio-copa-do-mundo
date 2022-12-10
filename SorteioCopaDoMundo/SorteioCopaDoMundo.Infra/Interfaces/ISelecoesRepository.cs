using SorteioCopaDoMundo.Domain.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace SorteioCopaDoMundo.Infra.Interfaces
{
    public interface ISelecoesRepository : Common.IRepository
    {
        Selecoes Add(Selecoes selecoes);
    }
}
