using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using static Metodos.Metodos;

namespace calculadora
{
 

    internal class Principal
    {
        static void Main(string[] args)
        {
            bool repete = true;
            while (repete == true)
            {
                Console.WriteLine("Qual operação deseja fazer: \n");
                Console.WriteLine("1- Adição \n");
                Console.WriteLine("2- Subtração \n");
                Console.WriteLine("3- Multiplicação \n");
                Console.WriteLine("4- Divisão \n");

                //Aqui provavavelmente terei que criar outra classe pra colocar essa dentro, pra fazer o looping
                int operacao = int.Parse(Console.ReadLine());
                if (operacao != 1 && operacao != 2 && operacao != 3 && operacao != 4)
                {
                    Console.WriteLine("Operação inválida.");
                    return;
                }

                Console.WriteLine("Digite o primeiro número: ");
                int num1 = int.Parse(Console.ReadLine());

                Console.WriteLine("Digite o segundo número: ");
                int num2 = int.Parse(Console.ReadLine());

                int resultado = 0;

                switch (operacao)
                {
                    case 1:
                        {
                            resultado = Metodos.Metodos.Adicao(num1, num2);
                            break;
                        }
                    case 2:
                        {
                            resultado = Metodos.Metodos.Subtracao(num1, num2);
                            break;
                        }
                    case 3:
                        {
                            resultado = Metodos.Metodos.Multiplicacao(num1, num2);
                            break;
                        }
                    case 4:
                        {
                            resultado = Metodos.Metodos.Divisao(num1, num2);
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Número invalido.");
                            break;
                        }
                }

                Console.WriteLine("O resultado da operação é: {0}", resultado);
                Console.WriteLine("Deseja fazer outra operação? \n");
                Console.WriteLine("1- Sim \n0- Não");
                int repeteInt = int.Parse(Console.ReadLine());
                if (repeteInt == 0)
                {
                    repete = false;
                }
            }
  
        }

     
    }

}


