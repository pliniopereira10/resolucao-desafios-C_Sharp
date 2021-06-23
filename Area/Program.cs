using System;
using System.Globalization;

namespace Area
{
    class Program
    {
        static void Main(string[] args)
        {
            string [] valores;
            double valorUm, valorDois, valorTres;
            double areaDoTriangulo, areaDoCirculo, areaDoTrapezio;
            double areaDoQuadrado, areaDoRetangulo;

            Console.WriteLine("Informe três valores:");
            valores = Console.ReadLine().Split(' ');

            valorUm = double.Parse(valores [0], CultureInfo.InvariantCulture);
            valorDois = double.Parse(valores [1], CultureInfo.InvariantCulture);
            valorTres = double.Parse(valores [2], CultureInfo.InvariantCulture);

            areaDoTriangulo = valorUm * valorTres / 2;
            areaDoCirculo = 3.14159 * valorTres * valorTres;
            areaDoTrapezio = (valorUm + valorDois) * valorTres / 2;
            areaDoQuadrado = valorDois * valorDois;
            areaDoRetangulo = valorUm * valorDois;

            Console.WriteLine("TRIANGULO: " + areaDoTriangulo.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("CIRCULO: " + areaDoCirculo.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("TRAPEZIO: " + areaDoTrapezio.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("QUADRADO: " + areaDoQuadrado.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("RETANGULO: " + areaDoRetangulo.ToString("F3", CultureInfo.InvariantCulture));



        }
    }
}
