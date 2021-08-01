// Programa recebe dois numeros e soma todos valores entre esses numeros que
// não são múltiplos de 13.

using System;

namespace Multiplo13
{
    class Program
    {
        static void Main(string[] args)
        {
            int valorUm, valorDois, min, max, soma;
            soma = 0;

            valorUm = int.Parse(Console.ReadLine());
            valorDois = int.Parse(Console.ReadLine());

            if (valorUm < valorDois)
            {
                min = valorUm;
                max = valorDois;

            } else {
                min = valorDois;
                max = valorUm;
            }

            for (int cont = min; cont <= max; cont++)
            {
                if (cont % 13 != 0)
                {
                    soma += cont;
                }
            }
            Console.WriteLine(soma);
        }
    }
}
