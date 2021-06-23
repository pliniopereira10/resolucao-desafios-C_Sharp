using System;
using System.Globalization;

namespace VolumeDaEsfera
{
    class Program
    {
        static void Main(string[] args)
        {
            double volume;
            double pi;
            double raio;

            pi = 3.14159;
           
            Console.Write("Digite o raio da esfera: ");
            raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            raio = Math.Pow(raio, 3);
            volume = (4.0 / 3) * pi * raio;

            Console.WriteLine("VOLUME = " + volume.ToString("F3", CultureInfo.InvariantCulture));
        }
    }
}
