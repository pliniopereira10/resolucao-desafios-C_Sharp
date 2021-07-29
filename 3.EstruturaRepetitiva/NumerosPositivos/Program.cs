using System;
using System.Globalization;

namespace NumerosPositivos
{
    class Program
    {
        static void Main(string[] args)
        {
            double numero;
            int negativo, positivo, cont;
            negativo = 0;
            positivo = 0;
            cont = 0;
            
            Console.WriteLine("Programa informará quantos números são positivos.");
            Console.WriteLine("Insira 6 numeros:");

            do
            {
        
                numero = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                if (numero > 0) {
                    positivo ++;

                } else {
                    negativo ++;

                }
                cont ++;

                
            } while (cont < 6);

            Console.WriteLine(positivo + " valores positivos");
        }
    }
}
