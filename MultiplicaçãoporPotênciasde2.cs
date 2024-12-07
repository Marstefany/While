using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class MultiplicaçãoporPotênciasde2
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Digite um numero");
            int numero = Convert.ToInt32(Console.ReadLine());
            int resultado = numero;
            int potencia = 0;

            Console.WriteLine("Multiplicação de " + numero + " por potencias de 2: ");

            while (resultado <= 1000)
            {
                Console.WriteLine(numero + " x 2^" + potencia + " = " + resultado);
                potencia++;
                resultado = numero * (int)Math.Pow(2, potencia);
            }

            Console.WriteLine("Fim da sequência (o valor ultrapassou 1000).");
        }
    }
}
