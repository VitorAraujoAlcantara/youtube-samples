using CicloAprovacao.Interfaces;
using CicloAprovacao.Models;

namespace CicloAprovacao.States;

public abstract class AbstractEstadoProjeto : IEstadoProjeto
{
    protected ProjetoContext _projetoContext;
    public string NomeDoEstado => this.ToString();

    public abstract void Aprovar();    

    public abstract void Devolver();
    
    public abstract void Reprovar();
    
    public void SetaContext(ProjetoContext contexto)
    {
        _projetoContext = contexto;
    }
}