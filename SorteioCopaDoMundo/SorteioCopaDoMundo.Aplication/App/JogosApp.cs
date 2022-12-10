using SorteioCopaDoMundo.Domain.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace SorteioCopaDoMundo.Aplication.App
{
    public class JogosApp : Interfaces.IJogos
    {
        private readonly Infra.Interfaces.IJogosRepository jogosRepository;

        public JogosApp(Infra.Interfaces.IJogosRepository jogos)
        {
            this.jogosRepository = jogos;
        }
        public Jogos Add(Jogos jogos)
        {
            throw new NotImplementedException();
        }
    }
}
