namespace CicloAprovacao.States;

public class EstadoNovo : AbstractEstadoProjeto
{
    public override void Aprovar()
    {
        _projetoContext.AlterarEstado( 
            new EstadoRevisaoInicial()
        );
    }

    public override void Devolver()
    {
        throw new Exception("Não pode ser devolvido no estado atual.");
    }

    public override void Reprovar()
    {
        _projetoContext.AlterarEstado( 
            new EstadoReprovado()
        );
    }
}