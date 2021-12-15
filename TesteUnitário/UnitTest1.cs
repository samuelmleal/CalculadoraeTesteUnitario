using System;
using Xunit;
using CalculadoraeTesteUnitario;

namespace TesteUnitário
{
    public class UnitTest1
    {
        [Theory]

        [InlineData(1,2,3)]
        [InlineData(4,5,9)]
        public void TestSomar   (int val1, int val2, int resultado)
        {

            Calculadora calc = new Calculadora();

            int resultadoCalculadora = calc.soma(val1, val2);

            Assert.Equal(resultado, resultadoCalculadora);
        }

        [Theory]

        [InlineData(1, 2, 2)]
        [InlineData(4, 5, 20)]
        public void TestMultiplicar(int val1, int val2, int resultado)
        {

            Calculadora calc = new Calculadora();

            int resultadoCalculadora = calc.multiplicar(val1, val2);

            Assert.Equal(resultado,resultadoCalculadora);
        }
        [Theory]

        [InlineData(10, 5, 5)]
        [InlineData(9, 3, 6)]
        public void TestSubtrair(int val1, int val2, int resultado)
        {

            Calculadora calc = new Calculadora();

            int resultadoCalculadora = calc.subtrair(val1, val2);

            Assert.Equal(resultado, resultadoCalculadora);
        }
        [Theory]

        [InlineData(10, 2, 5)]
        [InlineData(6, 3, 2)]
        public void TestDividir(int val1, int val2, int resultado)
        {

            Calculadora calc = new Calculadora();

            int resultadoCalculadora = calc.dividir(val1, val2);

            Assert.Equal(resultado, resultadoCalculadora);
        }

        [Fact]
        public void TestDividirPorZero()
        {
            Calculadora calc = new Calculadora();

            Assert.Throws<DivideByZeroException>(
                () => calc.dividir(3, 0)
                );
        }

        [Fact]

        public void TestarHistorico()
        {
            Calculadora calc = new Calculadora();

            calc.soma(1, 3);
            calc.dividir(6, 2);
            calc.multiplicar(5, 3);

            var lista = calc.historico();

            Assert.NotEmpty(lista);
            Assert.Equal(3, lista.Count);           
        }
    }
}
