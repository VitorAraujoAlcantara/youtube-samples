namespace CicloAprovacao.States;

public class EstadoReprovado : AbstractEstadoProjeto
{
    public override void Aprovar()
    {
        throw new Exception("O projeto foi reprovado!");
    }

    public override void Devolver()
    {
        throw new Exception("O projeto foi reprovado!");
    }

    public override void Reprovar()
    {
        throw new Exception("O projeto foi reprovado!");
    }
}