using System;
using teste.services;
using teste.services.Exceptions;
using teste.services.Interfaces;
using Xunit;

namespace teste.test.Services
{
    public class CalculadoraTest
    {
        private readonly ICalculadora calculadora;
        public CalculadoraTest()
        {
            calculadora = new Calculadora();
        }

        [Fact(DisplayName = "SomaDoisNumeros: 01 - Deve calcular a soma de dois numeros")]
        public void SomaDoisNumeros_01()
        {
            int numero1 = 10;
            int numero2 = 5;
            int resultadoEsperado = 15;

            int resultado = calculadora.SomaDoisNumeros(numero1, numero2);
            Assert.Equal(resultadoEsperado, resultado);
        }

        [Fact(DisplayName = "DividirDoisNumeros: 01 - Quando segundo numero for igual a zero deve subir DivisaoPorZeroException")]
        public void DividirDoisNumeros_01()
        {
            int numero1 = 10;
            int numero2 = 0;

            Assert.Throws<DivisaoPorZeroException>(() => calculadora.DividirDoisNumeros(numero1, numero2));
        }

        [Fact(DisplayName = "DividirDoisNumeros: 02 - Quando segundo numero não for igual a zero deve não subir DivisaoPorZeroException")]
        public void DividirDoisNumeros_02()
        {
            int numero1 = 10;
            int numero2 = 5;

            try
            {
                calculadora.DividirDoisNumeros(numero1, numero2);
                Assert.True(true);
            }
            catch (Exception)
            {
                Assert.False(true);
            }
        }

        [Fact(DisplayName = "DividirDoisNumeros: 03 - Deve calcular o resultado da divisao corretamente")]
        public void DividirDoisNumeros_03()
        {
            int numero1 = 10;
            int numero2 = 5;
            int resultadoEsperado = 2;

            int resultado = calculadora.DividirDoisNumeros(numero1, numero2);

            Assert.Equal(resultadoEsperado, resultado);
        }


    }
}
