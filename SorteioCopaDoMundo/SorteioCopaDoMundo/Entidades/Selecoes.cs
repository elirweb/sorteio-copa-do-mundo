using SorteioCopaDoMundo.Domain.Comum;

namespace SorteioCopaDoMundo.Domain.Entidades
{
    public class Selecoes: Base
    {
        public string Nome { get; set; }
        public int Ranking { get; set; }
        public string Continent { get; set; }
      
        public Selecoes(Selecoes selecoes)
        {
            Nome = selecoes.Nome;
            Ranking = selecoes.Ranking;
            Continent = selecoes.Continent;
        }
        
    }

    
}
