﻿using System;
using System.Globalization;

namespace ExRes002MedidasRetangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            string [] valores;            
            double altura, basi;
            double area, perimetro, diagonal;
            
            Console.WriteLine("Informe a base e altura do retângulo:");
            valores = Console.ReadLine().Split(' ');

            altura = double.Parse(valores [0], CultureInfo.InvariantCulture);
            basi = double.Parse(valores [1], CultureInfo.InvariantCulture);

            area = basi * altura ;
            perimetro = 2 * (basi + altura);
            diagonal = Math.Sqrt(Math.Pow(basi, 2) + Math.Pow(altura, 2));

            Console.WriteLine("AREA = " + area.ToString("F4"), CultureInfo.InvariantCulture);
            Console.WriteLine("Perimetro = " + perimetro.ToString("F4"), CultureInfo.InvariantCulture);
            Console.WriteLine("Diagonal = " + diagonal.ToString("F4"), CultureInfo.InvariantCulture);

        }
    }
}