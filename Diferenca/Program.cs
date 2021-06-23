using System;

namespace Diferenca
{
    class Program
    {
        static void Main(string[] args)
        {
            int valorUm, valorDois, valorTres, valorQuatro, diferenca;

            Console.WriteLine("Digite quatro valores.");
            
            Console.Write("1º valor: ");
            valorUm = int.Parse(Console.ReadLine());

            Console.Write("2º valor: ");
            valorDois = int.Parse(Console.ReadLine());

            Console.Write("3º valor: ");
            valorTres = int.Parse(Console.ReadLine());

            Console.Write("4º valor: ");
            valorQuatro = int.Parse(Console.ReadLine());

            diferenca = (valorUm * valorDois - valorTres * valorQuatro);

            Console.WriteLine("DIFERENCA = " + diferenca);

        }
    }
}
