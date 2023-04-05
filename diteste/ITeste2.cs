namespace diteste;

public interface ITeste2{
    void Executar();
}

public class Teste2 : ITeste2
{
    private readonly ITeste1 _teste1;

    public Teste2(ITeste1 teste1)
    {
        _teste1 = teste1;
    }
    public void Executar()
    {
        _teste1.Executar();
    }
}