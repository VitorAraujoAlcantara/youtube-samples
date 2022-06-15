using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using teste.services.Interfaces;

namespace teste.api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CalculadoraController : ControllerBase
    {
        private readonly ICalculadora _calculadora;

        public CalculadoraController(ICalculadora calculadora)
        {
            _calculadora = calculadora;
        }

        [HttpGet("/somma")]
        public int Calculadora ( int numero1, int numero2)
        {
            return _calculadora.SomaDoisNumeros(numero1, numero2);
        }

        [HttpGet("/divisao")]
        public int Divisao(int numero1, int numero2)
        {
            return _calculadora.DividirDoisNumeros(numero1, numero2);
        }
    }
}
