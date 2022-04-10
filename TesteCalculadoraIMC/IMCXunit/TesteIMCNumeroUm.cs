using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TesteCalculadoraIMC;
using Xunit;

namespace IMCXunit
{
    public class TesteIMCNumeroUm
    {
        [Fact]
        public void TesteIMC_1()
        {
            double valor1 = 95;
            double valor2 = 1.87;

            var resultado = OperacaoIMC.CalcularIMC(valor1, valor2);

            Assert.InRange(resultado, 18.5, 39.9);
        }
    }
}
