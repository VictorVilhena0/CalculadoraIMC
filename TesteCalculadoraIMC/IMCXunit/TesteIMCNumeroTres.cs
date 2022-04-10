using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TesteCalculadoraIMC;
using Xunit;

namespace IMCXunit
{
    public class TesteIMCNumeroTres
    {
        [Fact]
        public void TesteIMC_1()
        {
            double valor1 = 150;
            double valor2 = 1.73;

            var resultado = OperacaoIMC.CalcularIMC(valor1, valor2);

            Assert.InRange(resultado, 40, 1000);
        }
    }
}
