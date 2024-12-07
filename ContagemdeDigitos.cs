using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class ContagemdeDigitos
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Digite um número inteiro: ");
            int numero = Convert.ToInt16(Console.ReadLine());
            int digitos = 0;

            if (numero == 0)
            {
                digitos = 1;
            }
            else
            {
                while (numero > 0)
                {
                    numero /= 10;
                    digitos++;
                }
            }

            Console.WriteLine("O número digitado possui " + digitos + " dígito(s).");
        }
    }
}
