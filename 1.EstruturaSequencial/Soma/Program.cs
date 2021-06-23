using System;

namespace Soma
{
    class Program
    {
        static void Main(string[] args)
        {
            int valorUm, valorDois, soma;

            Console.Write("Digite primeiro número: ");
            valorUm = int.Parse(Console.ReadLine());

            Console.Write("Digite segundo número: ");
            valorDois = int.Parse(Console.ReadLine());

            soma = valorUm + valorDois;

            Console.WriteLine("SOMA = " + soma);
        }
    }
}
