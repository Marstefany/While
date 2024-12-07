using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class ContarParÍmpar
    {
        public static void Main(string[] args)
        {
            int numero, pares = 0, impares = 0;

            Console.WriteLine("Digite números inteiros (digite 0 para sair):");

            do
            {
                Console.WriteLine("Digite um número: ");
                numero = Convert.ToInt32(Console.ReadLine());

                if (numero == 0)
                    break;

                if (numero % 2 == 0)
                    pares++;
                else
                    impares++;

            } while (numero != 0);

            Console.WriteLine("Total de números pares: " + pares);
            Console.WriteLine("Total de números ímpares: " + impares);
        }
    }
}
