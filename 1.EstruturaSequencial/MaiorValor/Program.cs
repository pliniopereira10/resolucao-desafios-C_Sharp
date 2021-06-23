using System;

namespace MaiorValor
{
    class Program
    {
        static void Main(string[] args)
        {
            // Formula: MaiorAB = (a + b + abs(a - b)) / 2
            string [] mensagem;
            int valorA, valorB, valorC;
            int maiorAB, maior;

            Console.WriteLine("Informe 3 valores:");
            mensagem = Console.ReadLine().Split(' ');

            valorA = int.Parse(mensagem [0]);
            valorB = int.Parse(mensagem [1]);
            valorC = int.Parse(mensagem [2]);

            maiorAB = (valorA + valorB + Math.Abs(valorA - valorB)) / 2;

            maior = (maiorAB + valorC + Math.Abs(maiorAB - valorC)) / 2;

            Console.WriteLine(maior + " eh o maior");


        }
    }
}
