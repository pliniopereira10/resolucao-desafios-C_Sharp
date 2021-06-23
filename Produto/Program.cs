using System;

namespace Produto
{
    class Program
    {
        static void Main(string[] args)
        {
            int valorUm, valorDois, produto;

            Console.Write("Digite um número: ");
            valorUm =  int.Parse(Console.ReadLine());

            Console.Write("Digite outro número: ");
            valorDois =  int.Parse(Console.ReadLine());

            produto = valorUm * valorDois;

            Console.WriteLine("PROD = " + produto);
        }
    }
}
