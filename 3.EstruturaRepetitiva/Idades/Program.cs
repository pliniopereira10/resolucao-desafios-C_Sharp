using System;
using System.Globalization;

namespace Idades
{
    class Program
    {
        static void Main(string[] args)
        {
            int idade, cont; 
            cont = 0;

            double media, soma;
            soma = 0.0;

            Console.WriteLine("\tCálculo da média das idades");
            Console.WriteLine("digite valor negativo para visualizar a média");
            Console.WriteLine("Informe a idade:");
            idade = int.Parse(Console.ReadLine());

            while (idade > 0)
            {
                if (idade > 0)
                {
                    cont ++;
                    soma += idade; 
                }
                Console.WriteLine("outra idade");
                idade = int.Parse(Console.ReadLine());

            }

            media = soma / cont;
            Console.WriteLine("A média das idades digitadas é " + media.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}
