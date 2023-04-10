using CicloAprovacao.Models;
namespace CicloAprovacao.Interfaces;


public interface IEstadoProjeto {
    void SetaContext(ProjetoContext contexto);
    void Aprovar();
    void Devolver();
    void Reprovar();

    string NomeDoEstado { get; }
}