using System;
using System.Globalization;

namespace ConsumoCombustivel
{
    class Program
    {
        static void Main(string[] args)
        {
            int distanciaKm;
            double totalConsumido, consumoMedio;

            Console.Write("Digite a distância percorrida: Km ");
            distanciaKm = int.Parse(Console.ReadLine());
            Console.Write("Quantos litros consumido: L ");
            totalConsumido = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            consumoMedio = distanciaKm / totalConsumido;

            Console.WriteLine(consumoMedio.ToString("F3", CultureInfo.InvariantCulture) + " km/l");

        }
    }
}
