using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class VerificaçãodeParidade
    {  
            public static void Main(string[] args)
            {
                int numero = 0;
                Console.WriteLine("Digite números inteiros. O programa termina quando um número par for digitado.");

                do
                {
                    Console.Write("Digite um número: ");

                    numero = Convert.ToInt32(Console.ReadLine());

                    if (numero % 2 != 0)
                    {
                        Console.WriteLine("O numero e impar Continue");
                    }
                } while (numero % 2 != 0);
                Console.WriteLine("Parabéns! Você digitou um número par. Programa encerrado.");
            }
        }
    }
}

