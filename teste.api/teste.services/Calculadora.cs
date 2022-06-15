using System.Runtime.CompilerServices;
using teste.services.Exceptions;
using teste.services.Interfaces;

[assembly: InternalsVisibleTo("teste.test")]
namespace teste.services
{
    internal class Calculadora : ICalculadora
    {
        public int DividirDoisNumeros(int numero1, int numero2)
        {
            if ( numero2 == 0)
            {
                throw new DivisaoPorZeroException();
            }
            return numero1 / numero2;
        }

        public int SomaDoisNumeros(int numero1, int numero2)
        {
            return numero1 + numero2;
        }
    }
}
