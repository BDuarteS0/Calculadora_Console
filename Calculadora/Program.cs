using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace calculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual operação deseja fazer: \n");
            Console.WriteLine("1- Adição \n");
            Console.WriteLine("2- Subtração \n");
            Console.WriteLine("3- Multiplicação \n");
            Console.WriteLine("4- Divisão \n");


            int operacao = int.Parse(Console.ReadLine());
            if(operacao != 1 && operacao != 2 && operacao != 3 && operacao != 4)
            {
                Console.WriteLine("Operação inválida.");
                return;
            }

            Console.WriteLine("Digite o primeiro número: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o primeiro número: ");
            int num2 = int.Parse(Console.ReadLine());

            int resultado = 0;

            switch (operacao)
            {
                case 1:
                    {
                        resultado = Adicao(num1, num2);
                        break;
                    }
                case 2:
                    {
                        resultado = Subtracao(num1,num2); 
                        break;
                    }
                case 3:
                    {
                        resultado = Multiplicacao(num1, num2);
                        break;
                    }
                case 4:
                    {
                        resultado = Divisao(num1, num2);
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Número invalido.");
                        break;
                    }
            }

            Console.WriteLine("O resultado da operação é: {0}", resultado);

  
        }

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
            int resultado = num1 * num2;
            return resultado;
        }


        public static int Divisao(int num1, int num2)
        {
            int resultado = num1 / num2;
            return resultado;
        }
    }

}


