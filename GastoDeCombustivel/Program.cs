using System;

namespace GastoDeCombustivel
{
    class Program
    {
        static void Main(string[] args)
        {
            int tempoGasto, velocidadeMedia, distanciaPercorrida;
            double  mediaDeConsumo,totalConsumido;

            mediaDeConsumo = 12;

            Console.WriteLine("Qual tempo gasto na viagem ?");
            tempoGasto = int.Parse(Console.ReadLine());
            Console.WriteLine("Qual a velocidade média ?");
            velocidadeMedia = int.Parse(Console.ReadLine());

            distanciaPercorrida = tempoGasto * velocidadeMedia ;

            totalConsumido = distanciaPercorrida / mediaDeConsumo;

            Console.WriteLine("Total consumido: " + totalConsumido.ToString("F3"));


        }
    }
}
