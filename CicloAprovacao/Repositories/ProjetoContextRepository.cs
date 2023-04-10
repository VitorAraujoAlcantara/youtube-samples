using CicloAprovacao.Models;
using CicloAprovacao.States;

namespace CicloAprovacao.Repositories;

public class ProjetoContextRepository{
    private Dictionary<Guid, ProjetoContext> _contexts = new Dictionary<Guid, ProjetoContext>();

    public ProjetoContext Post(Projeto projeto){
        projeto.Id = Guid.NewGuid();
        ProjetoContext retorno = new ProjetoContext(new EstadoNovo() ){
            Projeto = projeto
        };

        _contexts.Add(projeto.Id, retorno);

        return retorno;
    }

    public ProjetoContext Update( Guid id, Projeto projeto ){
        if ( ! _contexts.TryGetValue(id, out ProjetoContext _context)){
            throw new Exception("Chave não encontrada");
        }

        _context.Projeto = projeto;

        return _context;
    }

    public void Delete( Guid id ){
        if ( ! _contexts.ContainsKey(id)){
            throw new Exception ("Chave não encontrada");
        }

        _contexts.Remove(id);
    }

    public List<ProjetoContext> GetAll(){
        return _contexts.Values.ToList();
    }

    public ProjetoContext Get(Guid id){
        if ( ! _contexts.TryGetValue(id, out ProjetoContext _context)){
            throw new Exception("Chave não encontrada");
        }
        
        return _context;
    }
}