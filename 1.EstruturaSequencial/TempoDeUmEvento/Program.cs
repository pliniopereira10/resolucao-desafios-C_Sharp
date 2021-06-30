using System;

namespace TempoDeUmEvento
{
    class Program
    {
        static void Main(string[] args)
        {
            string [] tempo;
            int diaInicial, horasInicial, minutosInicial, segundosInicial; 
            int diaFinal, horasFinal, minutosFinal, segundosFinal;
            int tempoTotalEmSegundosUm, tempoTotalEmSegundosDois, segundosTotal;
            int dias, horas, minutos, segundos, resto;
     
            Console.WriteLine("Inicio do evento:");
            Console.Write("Dia ");
            diaInicial = int.Parse(Console.ReadLine());
            tempo = Console.ReadLine().Split(' ');

            horasInicial = int.Parse(tempo [0]);
            minutosInicial =  int.Parse(tempo [2]);
            segundosInicial = int.Parse(tempo [4]);


            Console.WriteLine("Término do evento:");
            Console.Write("Dia ");
            diaFinal = int.Parse(Console.ReadLine());
            tempo = Console.ReadLine().Split(' ');

            horasFinal = int.Parse(tempo [0]);
            minutosFinal = int.Parse(tempo [2]);
            segundosFinal = int.Parse(tempo [4]);

            tempoTotalEmSegundosUm = diaInicial * 86400 + horasInicial * 3600 + minutosInicial * 60 + segundosFinal;

            tempoTotalEmSegundosDois = diaFinal * 86400 + horasFinal * 3600 + minutosFinal * 60 + segundosFinal;

            segundosTotal = Math.Abs(tempoTotalEmSegundosUm - tempoTotalEmSegundosDois);

            dias =  segundosTotal / 86400;
            resto = segundosTotal % 86400;

            horas = resto / 3600;
            resto = resto % 3600;

            minutos = resto / 60;
            resto = resto % 60;

            segundos = resto;

            Console.WriteLine(dias + " dia(s)");
            Console.WriteLine(horas + " hora(s)");
            Console.WriteLine(minutos + " minuto(s)");
            Console.WriteLine(segundos + " segundo(s)");
            


        }
    }
}
