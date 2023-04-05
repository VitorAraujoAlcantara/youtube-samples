namespace diteste;

public interface ITeste1: IDisposable
{
    void Executar();
}

public class Teste1 : ITeste1
{
    private int _contador = 0;


    public Teste1()
    {
        Console.WriteLine("INICIALIZOU");
    }

    public void Dispose()
    {
        Console.WriteLine("FINALIZOU");
    }

    public void Executar()
    {
        _contador = _contador + 1;

        Console.WriteLine($"O valor do nosso contador é {_contador}");
    }
}