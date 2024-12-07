using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class ContagemdeVogais
    {
         
        public static void main(string[] args)
        {
            string entrada;
            int contadorVogais;

            Console.WriteLine("Digite 'fim' para encerrar o programa.");
            do
            {
                Console.Write("Digite uma palavra ou frase: ");
                entrada = Console.ReadLine();

                if (entrada == "fim")
                    break;

                contadorVogais = 0;
                foreach (char c in entrada)
                {
                    if ("aeiouAEIOU".Contains(c))
                        contadorVogais++;
                }

                Console.WriteLine($"Número de vogais: {contadorVogais}");


            } while (true);
        }
    }

    }

