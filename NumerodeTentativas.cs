using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class NumerodeTentativas
    {
        public static void Main(string[] args)
        {
            int numero;

            do
            {
                Console.WriteLine("Digite um número entre 1 e 100: ");
                numero = Convert.ToInt16(Console.ReadLine());

                if (numero < 1 || numero > 100)
                {
                    Console.WriteLine("Número inválido! Tente novamente.");
                }

            } while (numero < 1 || numero > 100);

            Console.WriteLine("Número válido digitado: " + numero);
        }
    }
}
