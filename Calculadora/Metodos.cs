using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodos
{
    internal class Metodos
    {
        public static int Adicao(int num1, int num2)
        {
            int resultado = num1 + num2;
            return resultado;
        }

        public static int Subtracao(int num1, int num2)
        {
            int resultado = num1 - num2;
            return resultado;
        }

        public static int Multiplicacao(int num1, int num2)
        {
            int MultiLocal = num1 * num2;
            int resultado = MultiLocal;
            return resultado;
        }

        public static int Divisao(int num1, int num2)
        {
            int resultado = num1 / num2;
            return resultado;
        }
    }
}
