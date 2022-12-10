using SorteioCopaDoMundo.Domain.Entidades;
using SorteioCopaDoMundo.Infra.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace SorteioCopaDoMundo.Infra.Repositorios
{
    public class SelecoesRepository : Common.RepositoryBase<Selecoes>, ISelecoesRepository
    {
        public Selecoes Add(Selecoes selecoes)
        {
            throw new NotImplementedException();
        }
    }
}
