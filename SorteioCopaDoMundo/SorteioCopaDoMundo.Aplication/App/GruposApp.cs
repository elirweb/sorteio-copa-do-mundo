using SorteioCopaDoMundo.Domain.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SorteioCopaDoMundo.Aplication.App
{
    public class GruposApp : Interfaces.IGrupos
    {
        private readonly SorteioCopaDoMundo.Infra.Interfaces.IGruposRepository gruposRepository;

        public GruposApp(SorteioCopaDoMundo.Infra.Interfaces.IGruposRepository grupos)
        {
            this.gruposRepository = grupos;
        }
        public Grupos Add(List<Selecoes> selecoes)
        {
            if ((selecoes.Count / 4) == 0) 
            {
                
            }

            
            throw new NotImplementedException();
        }
    }
}
