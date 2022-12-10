using SorteioCopaDoMundo.Domain.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace SorteioCopaDoMundo.Aplication.App
{
    public class SelecoesApp : Interfaces.ISelecoes
    {
        private readonly SorteioCopaDoMundo.Infra.Interfaces.ISelecoesRepository selecoesRepository;

        public SelecoesApp(SorteioCopaDoMundo.Infra.Interfaces.ISelecoesRepository selecoes)
        {
            this.selecoesRepository = selecoes;
        }
        public Selecoes Add(Selecoes selecoes)
        {
            throw new NotImplementedException();
        }
    }
}
