using System;
using System.Globalization;

namespace AreaDoCirculo
{
    class Program
    {
        static void Main(string[] args)
        {
            double area, raio;
            double constante = 3.14159;
            
            Console.Write("Digite o raio do círculo: ");
            raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            
            raio = Math.Pow(raio, 2);

            area = constante * raio;

            Console.WriteLine("Área= " + area.ToString("F4", CultureInfo.InvariantCulture));
            
        }
    }
}
