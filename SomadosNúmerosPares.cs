using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class SomadosNúmerosPares
    {
        public static void Main(string[] args)
        {
            int numero = 0;
            int somaPares = 0;
            Console.WriteLine("Digite números inteiros (digite 0 para encerrar):");
            do
            {
                Console.WriteLine("Digite um número: ");
                numero = Convert.ToInt32(Console.ReadLine());
                if (numero % 2 == 0 && numero != 0)
                    somaPares = somaPares + numero;

            } while (numero != 0);
            Console.WriteLine("A soma dos números pares digitados é: " + somaPares);
        }
    }
}
