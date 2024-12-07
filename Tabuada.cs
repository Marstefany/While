using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Tabuada
    {
            public static void Main(string[] args)
            {

                int multiplicacao = 1;
                Console.WriteLine("Digite um numero");
                int numero = Convert.ToInt32(Console.ReadLine());
                do
                {
                    int resultado = 0;
                    resultado = multiplicacao * numero;
                    Console.WriteLine("A tabuada do numero: " + numero);
                    Console.WriteLine(numero + " X " + multiplicacao + " = " + resultado);
                    multiplicacao++;
                } while (multiplicacao != 11);
            }
        }
}
