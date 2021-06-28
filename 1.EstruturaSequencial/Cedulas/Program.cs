using System;

namespace Cedulas
{
    class Program
    {
        static void Main(string[] args)
        {
            int notaCem, notaCinquenta, notaVinte, notaDez;
            int notaCinco, notaDois, notaUm, valor, resto;

            Console.WriteLine("Informe um valor em R$, para que o sistema indique a quantidade de notas necessárias.");
            Console.WriteLine("Digite o valor: ");
            valor = int.Parse(Console.ReadLine());

            notaCem = valor  / 100;
            resto = valor  % 100; 

            notaCinquenta = resto / 50;
            resto = resto % 50;

            notaVinte = resto / 20;
            resto = resto % 20;

            notaDez = resto / 10;
            resto = resto % 10;

            notaCinco = resto / 5;
            resto = resto % 5;

            notaDois = resto / 2;
            resto = resto % 2;

            notaUm = resto;

            Console.WriteLine(notaCem + " nota(s) de R$ 100,00");
            Console.WriteLine(notaCinquenta + " nota(s) de R$ 50,00");
            Console.WriteLine(notaVinte + " nota(s) de R$ 20,00");
            Console.WriteLine(notaDez + " nota(s) de R$ 10,00");
            Console.WriteLine(notaCinco + " nota(s) de R$ 5,00");
            Console.WriteLine(notaDois + " nota(s) de R$ 2,00");
            Console.WriteLine(notaUm + " nota(s) de R$ 1,00");



        }
    }
}
