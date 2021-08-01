using System;
using System.Globalization;

namespace DividindoXPorY
{
    class Program
    {
        static void Main(string[] args)
        {
            double valorX, valorY, divisao;
            int qtdCalculos;
            string [] valores;

            divisao = 0.0;

            qtdCalculos = int.Parse(Console.ReadLine());

            for (int cont = 0; cont < qtdCalculos; cont++)
            {
                valores = Console.ReadLine().Split();
                valorX = int.Parse(valores [0]);
                valorY = int.Parse(valores [1]);

                if (valorY == 0)
                {
                    Console.WriteLine("divisao impossivel");

                } else {
                    divisao = valorX / valorY;
                    Console.WriteLine(divisao.ToString("F1", CultureInfo.InvariantCulture));
                }

            }
        }
    }
}
