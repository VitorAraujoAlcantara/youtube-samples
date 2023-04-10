namespace CicloAprovacao.States;

public class EstadoRevisaoInicial : AbstractEstadoProjeto
{
    public override void Aprovar()
    {
        _projetoContext.AlterarEstado( 
            new EstadoAprovFinanceiro()
        );
    }

    public override void Devolver()
    {
        _projetoContext.AlterarEstado( 
            new EstadoNovo()
        );
    }

    public override void Reprovar()
    {
        _projetoContext.AlterarEstado( 
            new EstadoReprovado()
        );
    }
}