using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class BuscaDeUmNumero
    {
        public static void Main(string[] args)
        {
            int numeroSecreto = 3;
            int tentativa = 0;
            Console.WriteLine("Adivinhe o número secreto!");
            do
            {
                Console.WriteLine("Digite seu palpite: ");
                tentativa = Convert.ToInt32(Console.ReadLine());
                if (tentativa < numeroSecreto)
                {
                    Console.WriteLine("Muito baixo! Tente mais uma vez.");
                }
                else if (tentativa > numeroSecreto)
                {
                    Console.WriteLine("Muito alto! Tente novamente mais uma vez. ");
                }
                else
                {
                    Console.WriteLine("Parabens! Você acertou o número secreto.");
                }

            } while (tentativa != numeroSecreto);
        }
    }
}
