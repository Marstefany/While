using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class VerificaçãodeNúmeroPrimo
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Digite um número: ");
            int numero = Convert.ToInt16(Console.ReadLine());

            if (numero <= 1)
            {
                Console.WriteLine(numero + " não é um número primo.");
                return;
            }
            int divisor = 2;
            bool ehPrimo = true;
            do
            {
                if (numero % divisor == 0)
                {
                    ehPrimo = false;
                    break;
                }
                divisor++;
            } while (divisor < numero);
            if (ehPrimo)
            {
                Console.WriteLine(numero + " é um número primo.");
            }
            else
            {
                Console.WriteLine(numero + "não é um número primo.");
            }
        }
    }
}
