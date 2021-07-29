using System;
using System.Globalization;

namespace MediaPonderada
{
    class Program
    {
        static void Main(string[] args)
        {
            string [] valores;
            int qtdTestes;
            double valorUm, valorDois, valorTres, mediaPonderada;

            qtdTestes = int.Parse(Console.ReadLine());

            for (int cont = 0; cont < qtdTestes; cont++)
            {
                valores = Console.ReadLine().Split(' ');
                
                valorUm = double.Parse(valores [0], CultureInfo.InvariantCulture);
                valorDois = double.Parse(valores [1], CultureInfo.InvariantCulture);
                valorTres = double.Parse(valores [2], CultureInfo.InvariantCulture);

                mediaPonderada = (valorUm * 2 + valorDois * 3 + valorTres * 5) / 10;
                
                Console.WriteLine(mediaPonderada.ToString("F1", CultureInfo.InvariantCulture));
                
            }


        }
    }
}
