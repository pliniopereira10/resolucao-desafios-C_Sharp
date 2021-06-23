using System;
using System.Globalization;

namespace Media
{
    class Program
    {
        static void Main(string[] args)
        {
            double notaUm, notaDois, media;

            Console.Write("Digite uma nota: ");
            notaUm = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Digite outra nota: ");
            notaDois = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            media = (notaUm * 3.5 + notaDois * 7.5) / 11.0;

            Console.WriteLine("MEDIA = " + media.ToString("F5", CultureInfo.InvariantCulture));

        }
    }
}
