using SorteioCopaDoMundo.Domain.Entidades;
using SorteioCopaDoMundo.Infra.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace SorteioCopaDoMundo.Infra.Repositorios
{
    public class JogosRepository : Common.RepositoryBase<Jogos>, IJogosRepository
    {
        public Jogos Add(Jogos jogos)
        {
            throw new NotImplementedException();
        }
    }
}
