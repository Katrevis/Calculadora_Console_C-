using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    class Program
    {
        enum Menu { Soma = 1, Subtracao = 2, Multiplicacao = 3, Divisao = 4, Potencia = 5, Raiz = 6, Sair = 7}

        static void Main(string[] args)
        {
            bool escolherSair = false;
            while (!escolherSair)
            {
                Console.WriteLine("Seja bem vindo ao CALC, selecione uma das opções: ");
                Console.WriteLine("1-Soma\n2-Subtração\n3-Multiplicacao\n4-Divisao\n5-Potência\n6-Raiz\n7-Sair");

                Menu opcao = (Menu)int.Parse(Console.ReadLine());

               switch (opcao)
                {
                    case Menu.Soma:
                        Soma();
                        break;
                    case Menu.Subtracao:
                        Subtracao();
                        break;
                    case Menu.Multiplicacao:
                        Multiplicacao();
                        break;
                    case Menu.Divisao:
                        Divisao();
                        break;
                    case Menu.Potencia:
                        Potencia();
                        break;
                    case Menu.Raiz:
                        Raiz();
                        break;
                    case Menu.Sair:
                        escolherSair = true;
                        break;
                }

                Console.Clear();    

            }

        }

        static void Soma()
        {
            Console.WriteLine("Soma de dois numeros: ");
            Console.WriteLine("Digite o primeiro numero: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo numero: ");
            int b = int.Parse(Console.ReadLine());
            int resultado = a + b;
            Console.WriteLine($"O resultado é: {resultado} ");
            Console.WriteLine("Aperte enter para voltar ao menu");
            Console.ReadLine();
        }

        static void Subtracao()
        {
            Console.WriteLine("Subtração de dois numeros: ");
            Console.WriteLine("Digite o primeiro numero: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo numero: ");
            int b = int.Parse(Console.ReadLine());
            int resultado = a - b;
            Console.WriteLine($"O resultado é: {resultado} ");
            Console.WriteLine("Aperte enter para voltar ao menu");
            Console.ReadLine();
        }

        static void Multiplicacao()
        {
            Console.WriteLine("Multiplicação de dois numeros: ");
            Console.WriteLine("Digite o primeiro numero: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo numero: ");
            int b = int.Parse(Console.ReadLine());
            int resultado = a * b;
            Console.WriteLine($"O resultado é: {resultado} ");
            Console.WriteLine("Aperte enter para voltar ao menu");
            Console.ReadLine();
        }

        static void Divisao()
        {
            Console.WriteLine("Divisao de dois numeros: ");
            Console.WriteLine("Digite o primeiro numero: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo numero: ");
            int b = int.Parse(Console.ReadLine());
            float resultado = (float)a / (float)b;
            Console.WriteLine($"O resultado é: {resultado} ");
            Console.WriteLine("Aperte enter para voltar ao menu");
            Console.ReadLine();
        }


        static void Potencia()
        {
            Console.WriteLine("Potência de dois numeros: ");
            Console.WriteLine("Digite o primeiro numero: ");
            int baseNum = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o expoente: ");
            int expo = int.Parse(Console.ReadLine());
            double resultado = Math.Pow(baseNum, expo);
            Console.WriteLine($"O resultado é: {resultado} ");
            Console.WriteLine("Aperte enter para voltar ao menu");
            Console.ReadLine();
        }

        static void Raiz()
        {
            Console.WriteLine("Raiz de dois numeros: ");
            Console.WriteLine("Digite o numero: ");
            int a = int.Parse(Console.ReadLine());
            double resultado = Math.Sqrt(a);
            Console.WriteLine($"O resultado é: {resultado} ");
            Console.WriteLine("Aperte enter para voltar ao menu");
            Console.ReadLine();
        }
    }
}
