using System;

namespace ConversaoDeTempo
{
    class Program
    {
        static void Main(string[] args)
        {
            int horas, minutos, segundos;
            int valor, resto;

            Console.WriteLine("Informe os segundos:");
            valor = int.Parse(Console.ReadLine());

            horas = valor / 3600;
            resto = valor % 3600;
            minutos = resto / 60;
            segundos = resto % 60;

            Console.WriteLine(horas + ":" + minutos + ":" + segundos);
        }
    }
}
