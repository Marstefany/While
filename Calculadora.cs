using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Calculadora
    {
        public static void Main(string[] args)
        {
            int final;
            string caractere;
            double numero1;
            double numero2;
            double resultado;

            Console.WriteLine("=== Calculadora ===");
            Console.WriteLine("Operações disponíveis: +, -, *, /");
            Console.WriteLine("Digite 'sair' para encerrar o programa.");

            do
            {
                final = 1;

                Console.Write("Digite o primeiro número: ");
                numero1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Digite o segundo número: ");
                numero2 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Escolha uma operação (+, -, *, /) ou 'sair': ");
                caractere = Console.ReadLine();

                switch (caractere)
                {


                    case "+":
                        resultado = numero1 + numero2;
                        Console.WriteLine("O resultado é: " + resultado);
                        break;

                    case "-":
                        resultado = numero1 - numero2;
                        Console.WriteLine("O resultado é: " + resultado);
                        break;

                    case "*":
                        resultado = numero1 * numero2;
                        Console.WriteLine("O resultado é: " + resultado);
                        break;

                    case "/":
                        resultado = numero1 / numero2;
                        Console.WriteLine("O resultado é: " + resultado);
                        break;

                    case "sair":
                        final = 0;
                        break;

                }

            } while (final != 0);
        }
    }
}

