using System;

namespace IdadeEmDias
{
    class Program
    {
        static void Main(string[] args)
        {
            int anos, meses, dias;
            int resto, qtdDias;

            Console.WriteLine("Informe a quantidade de dias:");
            qtdDias = int.Parse(Console.ReadLine());

            anos = qtdDias / 365;
            resto = qtdDias % 365;

            meses = resto / 30;
            resto = resto % 30;

            dias = resto;

            Console.WriteLine(anos + " ano(s)");
            Console.WriteLine(meses + " mes(es)");
            Console.WriteLine(dias + " dia(s)");

        }
    }
}
