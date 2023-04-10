using CicloAprovacao.Interfaces;

namespace CicloAprovacao.Models;

public class ProjetoContext{    
    public Projeto Projeto { get; set; }
    public IEstadoProjeto Estado { get; set; }
    public ProjetoContext(IEstadoProjeto estado)
    {
        Estado = estado;
        Estado.SetaContext(this);
    }

    public void AlterarEstado(IEstadoProjeto estado){
        Estado = estado;
        Estado.SetaContext(this);
    }

    public void Aprovar(){
        Estado.Aprovar();
    }

    public void Reprovar(){
        Estado.Reprovar();
    }

    public void Devolver(){
        Estado.Devolver();
    }


}