using System;
using System.Globalization;

namespace Triangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            string [] valores;
            double valorUm, valorDois, valorTres;
            double perimetro, area;

            Console.WriteLine("Informe os lados do triângulo:");
            valores = Console.ReadLine().Split(' ');
            
            valorUm = double.Parse(valores [0], CultureInfo.InvariantCulture);
            valorDois = double.Parse(valores [1], CultureInfo.InvariantCulture);
            valorTres = double.Parse(valores [2], CultureInfo.InvariantCulture);

            if (valorUm + valorDois > valorTres && valorDois + valorTres > valorUm && valorTres + valorUm > valorDois) {
                perimetro = valorUm + valorDois + valorTres;
                Console.WriteLine("Perimetro = " + perimetro.ToString("F1", CultureInfo.InvariantCulture));

            } else {
                area = (valorUm + valorDois) * valorTres / 2;
                Console.WriteLine("Area = " + area.ToString("F1", CultureInfo.InvariantCulture));

            }

        }
    }
}
