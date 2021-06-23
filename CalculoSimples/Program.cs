using System;
using System.Globalization;

namespace CalculoSimples
{
    class Program
    {
        static void Main(string[] args)
        {
            string [] informacaoUm;
            string [] informacaoDois;
            int codigoUm, codigoDois, quantidadeUm, quantidadeDois;
            double valorUnitUm, valorUnitDois, valorTotal;

            Console.WriteLine("Peça 1.");
            Console.WriteLine("Digite o código, quantidade e valor da unidade:");
            informacaoUm = Console.ReadLine().Split(' ');

            codigoUm = int.Parse(informacaoUm [0]);
            quantidadeUm = int.Parse(informacaoUm [1]);
            valorUnitUm = double.Parse(informacaoUm [2],CultureInfo.InvariantCulture);

            Console.WriteLine("Peça 2.");
            Console.WriteLine("Digite o código, quantidade e valor da unidade:");
            informacaoDois = Console.ReadLine().Split(' ');

            codigoDois = int.Parse(informacaoDois [0]);
            quantidadeDois = int.Parse(informacaoDois [1]);
            valorUnitDois = double.Parse(informacaoDois [2],CultureInfo.InvariantCulture);

            valorTotal = quantidadeUm * valorUnitUm + quantidadeDois * valorUnitDois;

            Console.WriteLine("VALOR A PAGAR: R$ " + valorTotal.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}
