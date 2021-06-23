using System;
using System.Globalization;

namespace DistanciaEntreDoisPontos
{
    class Program
    {
        static void Main(string[] args)
        {
            string [] calculoPontoUm;
            string [] calculoPontoDois;
            double pontoUmX, pontoUmY, calculoX;
            double pontoDoisX, pontoDoisY, calculoY;
            double distanciaXy, somaXy;

            Console.WriteLine("Informe:");
            Console.WriteLine("Valores de X e Y do ponto 1.");
            calculoPontoUm = Console.ReadLine().Split(' ');

            pontoUmX = double.Parse(calculoPontoUm [0], CultureInfo.InvariantCulture);
            pontoUmY = double.Parse(calculoPontoUm [1], CultureInfo.InvariantCulture);

            Console.WriteLine("Informe:");
            Console.WriteLine("Valores de X e Y do ponto 2.");
            calculoPontoDois = Console.ReadLine().Split(' ');

            pontoDoisX = double.Parse(calculoPontoDois [0], CultureInfo.InvariantCulture);
            pontoDoisY = double.Parse(calculoPontoDois [1], CultureInfo.InvariantCulture);


            calculoX = Math.Pow(pontoDoisX - pontoUmX, 2.0);
            calculoY = Math.Pow(pontoDoisY - pontoUmY, 2.0);

            somaXy = calculoX + calculoY;

            distanciaXy = Math.Sqrt(somaXy);

            Console.WriteLine("A distância entre os pontos é " + distanciaXy.ToString("F4", CultureInfo.InvariantCulture));
            
            
        }
    }
}
