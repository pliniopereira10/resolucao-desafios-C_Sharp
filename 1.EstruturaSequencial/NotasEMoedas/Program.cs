using System;
using System.Globalization;

namespace Cedulas
{
    class Program
    {
        static void Main(string[] args)
        {
            int notaCem, notaCinquenta, notaVinte, notaDez;
            int notaCinco, notaDois, resto;

            int moedaUm, moedaCinquenta, moedaVinteECinco;
            int moedaDez, moedaCinco, moedaUmcent;
            double valor;

            Console.WriteLine("Informe um valor em R$, para que o sistema indique a quantidade de notas necessárias.");
            Console.WriteLine("Digite o valor: ");
            valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            resto = (int) (valor * 100.0 + 0.5);
            
            notaCem = resto / (100 * 100);
            resto = resto % (100 * 100); 

            notaCinquenta = resto / (50 * 100);
            resto = resto % (50 * 100);

            notaVinte = resto / (20 * 100);
            resto = resto % (20 * 100);

            notaDez = resto / (10 * 100);
            resto = resto % (10 * 100);

            notaCinco = resto / (5 * 100);
            resto = resto % (5 * 100);

            notaDois = resto / (2 * 100);
            resto = resto % (2 * 100);

            Console.WriteLine("NOTAS:");
            Console.WriteLine(notaCem + " nota(s) de R$ 100,00");
            Console.WriteLine(notaCinquenta + " nota(s) de R$ 50,00");
            Console.WriteLine(notaVinte + " nota(s) de R$ 20,00");
            Console.WriteLine(notaDez + " nota(s) de R$ 10,00");
            Console.WriteLine(notaCinco + " nota(s) de R$ 5,00");
            Console.WriteLine(notaDois + " nota(s) de R$ 2,00");
                       
            moedaUm = resto / 100;
            resto = resto % 100;

            moedaCinquenta = resto / 50;
            resto = resto % 50;

            moedaVinteECinco = resto / 25;
            resto = resto % 25;

            moedaDez = resto / 10;
            resto = resto % 10;

            moedaCinco = resto / 5; 
            resto = resto % 5;

            moedaUmcent = resto;           

            
            Console.WriteLine("MOEDAS:");
            Console.WriteLine(moedaUm + " moeda(s) de R$ 1,00");
            Console.WriteLine(moedaCinquenta + " moeda(s) de R$ 0,50");
            Console.WriteLine(moedaVinteECinco + " moeda(s) de R$ 0,25");
            Console.WriteLine(moedaDez + " moeda(s) de R$ 0,10");
            Console.WriteLine(moedaCinco + " moeda(s) de R$ 0,05");
            Console.WriteLine(moedaUmcent + " moeda(s) de R$ 0,01");
           
        }
    }
}