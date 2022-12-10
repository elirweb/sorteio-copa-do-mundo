using SorteioCopaDoMundo.Domain.Entidades;

namespace SorteioCopaDoMundo.Infra.Interfaces
{
    public interface IGruposRepository : Common.IRepository
    {
        Grupos Add(Grupos grupos);
        Selecoes ObterRaking(Selecoes selecoes);
    }
}
