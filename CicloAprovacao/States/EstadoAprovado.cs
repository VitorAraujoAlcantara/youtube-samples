namespace CicloAprovacao.States;

public class EstadoAprovado : AbstractEstadoProjeto
{
    public override void Aprovar()
    {
        throw new Exception("O projeto já se encontra liberado para excecução!");
    }

    public override void Devolver()
    {
        throw new Exception("O projeto já se encontra liberado para excecução!");
    }

    public override void Reprovar()
    {
        throw new Exception("O projeto já se encontra liberado para excecução!");
    }
}