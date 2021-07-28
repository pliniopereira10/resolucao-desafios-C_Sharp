using System;
using System.Globalization;

namespace VariasNotasValidacao
{
    class Program
    {
        static void Main(string[] args)
        {
            double notaUm, notaDois, media;
            int novoCalculo;
            novoCalculo = 1;

            while (novoCalculo == 1 ) {
               
                notaUm = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                
                while (notaUm < 0 || notaUm > 10)
                {
                    Console.WriteLine("nota invalida");
                    notaUm = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                }

                notaDois = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                
                while (notaDois < 0 || notaDois > 10)
                {
                    Console.WriteLine("nota invalida");
                    notaDois = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                }

                media = (notaUm + notaDois) / 2;

                Console.WriteLine("media = " + media.ToString("F2", CultureInfo.InvariantCulture));

                Console.WriteLine("novo calculo (1-sim 2-nao)");
                novoCalculo = int.Parse(Console.ReadLine());
                while (novoCalculo != 1 && novoCalculo != 2 )
                {
                    Console.WriteLine("novo calculo (1-sim 2-nao)");
                    novoCalculo = int.Parse(Console.ReadLine());
                }
            }
        }
    }
}
