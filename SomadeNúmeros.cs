using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class SomadeNúmeros
    {
        public static void Main(string[] args)
        {
            int numero = 0;
            int soma = 0;
            Console.WriteLine("Digite números inteiros para somar. Para encerrar, digite 0.");


            do
            {
                Console.WriteLine("Digite um numero");
                numero = Convert.ToInt32(Console.ReadLine());
                soma = soma + numero;
                Console.WriteLine("A soma dos números digitados é: " + soma);
            } while (numero != 0);
        }
    }
}
