using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TesteCalculadoraIMC;
using Xunit;

namespace IMCXunit
{
    public class TesteIMCNumeroDois
    {
        [Fact]
        public void TesteIMC_2()
        {
            double valor1 = 60;
            double valor2 = 1.9;

            var resultado = OperacaoIMC.CalcularIMC(valor1, valor2);

            Assert.InRange(resultado, 18.5, 24.9);
        }
    }
}
