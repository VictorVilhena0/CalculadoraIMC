using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteCalculadoraIMC
{
    public static class OperacaoIMC
    {
        public static double CalcularIMC(double peso, double altura)
        {
            return peso / (altura * altura);
        }
    }
}
