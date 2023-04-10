namespace CicloAprovacao.States;

public class EstadoAprovFinanceiro : AbstractEstadoProjeto
{
    public override void Aprovar()
    {

        if ( _projetoContext.Projeto.PrevisaoOrcamento > 100000 ){
            throw new Exception("Projeto superior ao valor máximo permitido");
        }

        _projetoContext.AlterarEstado( 
            new EstadoAproDiretoria()
        );
    }

    public override void Devolver()
    {
        _projetoContext.AlterarEstado( 
            new EstadoRevisaoInicial()
        );
    }

    public override void Reprovar()
    {
        _projetoContext.AlterarEstado( 
            new EstadoReprovado()
        );
    }
}