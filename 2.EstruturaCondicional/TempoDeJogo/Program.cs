using System;

namespace TempoDeJogo
{
    class Program
    {
        static void Main(string[] args)
        {
            int horaInicial, horaFinal, tempoJogo;
            String [] inicioFim;

            Console.WriteLine("Digite a hora Inicial e final de uma jogo:");
            inicioFim = Console.ReadLine().Split(' ');

            horaInicial = int.Parse(inicioFim [0]);
            horaFinal= int.Parse(inicioFim [1]);

            if (horaInicial  < horaFinal ) {
                tempoJogo = horaFinal - horaInicial;

            } else {
                tempoJogo = 24 - horaInicial + horaFinal;
            }

            Console.WriteLine("O JOGO DUROU " + tempoJogo + " HORA(S)");








        }
    }
}
