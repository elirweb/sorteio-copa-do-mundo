using SorteioCopaDoMundo.Domain.Comum;

namespace SorteioCopaDoMundo.Domain.Entidades
{
    public class Selecoes: Base
    {
        public string Nome { get; set; }
        public int Pontuacao { get; set; }
        public string Continente { get; set; }
      
        public Selecoes(Selecoes selecoes)
        {
            Nome = selecoes.Nome;
            Pontuacao = selecoes.Pontuacao;
            Continente = selecoes.Continente;
        }
        
    }

    
}
