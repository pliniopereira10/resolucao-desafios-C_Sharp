using System;

namespace TempoJogoMinutos
{
    class Program
    {
        static void Main(string[] args)
        {
            string []tempo;
            int horaInicial, minutoIncial, horaFinal, minutoFinal;
            int tempoInicial, tempoFinal;
            int tempoParcialMinutos, tempoTotalHoras, tempoTotalMinutos;

            Console.WriteLine("Favor informar horario de início e término do jogo:");
            Console.Write("Formato H M H M ");
            tempo = Console.ReadLine().Split(' ');

            horaInicial = int.Parse(tempo [0]);
            minutoIncial = int.Parse(tempo [1]);

            horaFinal = int.Parse(tempo [2]);
            minutoFinal = int.Parse(tempo [3]);

            tempoInicial = horaInicial * 60 + minutoIncial;
            tempoFinal = horaFinal * 60 + minutoFinal;

            if (tempoFinal > tempoInicial) {
                tempoParcialMinutos = tempoFinal - tempoInicial;

            } else {
                tempoParcialMinutos = (24 * 60 - tempoInicial) + tempoFinal;

            }

            tempoTotalHoras = tempoParcialMinutos / 60;
            tempoTotalMinutos = tempoParcialMinutos % 60;

            Console.WriteLine("O JOGO DUROU " + tempoTotalHoras + " HORA(S) E " + tempoTotalMinutos + " MINUTO(S)");

        }
    }
}
