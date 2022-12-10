using SorteioCopaDoMundo.Domain.Entidades;
using SorteioCopaDoMundo.Infra.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace SorteioCopaDoMundo.Infra.Repositorios
{
    public class GruposRepository : Common.RepositoryBase<Grupos>, IGruposRepository
    {
        public Grupos Add(Grupos grupos)
        {
            throw new NotImplementedException();
        }

        public Selecoes ObterRaking(Selecoes selecoes)
        {
            throw new NotImplementedException();
        }

        /*
            Regras de negocio:
Numero de selecoes deve ser divisivel por 4
selecoes com melhores pontuacoes devem ficar no pote A
As seguintes bem colocadas no grupo B
Depois no grupo C
e as piores colocadas no grupo D
         */
    }
}
