namespace CicloAprovacao.States;

public class EstadoAproDiretoria : AbstractEstadoProjeto
{
    public override void Aprovar()
    {
        _projetoContext.AlterarEstado(
            new EstadoAprovado()
        );
    }

    public override void Devolver()
    {
        _projetoContext.AlterarEstado(
            new EstadoAprovFinanceiro()
        );
    }

    public override void Reprovar()
    {
        _projetoContext.AlterarEstado(
            new EstadoReprovado()
        );
    }
}