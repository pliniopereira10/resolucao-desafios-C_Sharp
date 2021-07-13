using System;
using System.Globalization;

namespace Lanche
{
    class Program
    {
        static void Main(string[] args)
        {
            int codigo, quantidade;
            double valorTotal;
            String [] produto;

            Console.Write("********************");
            Console.WriteLine("********************");
            Console.WriteLine("\tTabela de Lanche");
            Console.Write("********************");
            Console.WriteLine("********************");

            Console.WriteLine(" CODIGO\t ESPECIFICAÇÂO\t\t PREÇO");
            Console.WriteLine(" 1\t Cachorro Quente\t R$ 4.00");
            Console.WriteLine(" 2\t X-Salada\t\t R$ 4.50");
            Console.WriteLine(" 3\t X-Bacon\t\t R$ 5.00");
            Console.WriteLine(" 4\t Torrada Simples\t R$ 2.00");
            Console.WriteLine(" 5\t Refrigerante\t\t R$ 1.50");
            Console.Write("********************");
            Console.WriteLine("********************");

            Console.WriteLine("Digite o código do produto e a quantidade:");
            produto = Console.ReadLine().Split(' ');

            codigo = int.Parse(produto [0]);
            quantidade = int.Parse(produto [1]);

            switch (codigo) {
                case 1:
                    valorTotal = quantidade * 4.00;
                    Console.WriteLine("Total: R$ " + valorTotal.ToString("F2", CultureInfo.InvariantCulture));
                    break;
                case 2:
                    valorTotal = quantidade * 4.50;
                    Console.WriteLine("Total: R$ " + valorTotal.ToString("F2", CultureInfo.InvariantCulture));
                    break;
                case 3:
                    valorTotal = quantidade * 5.00;
                    Console.WriteLine("Total: R$ " + valorTotal.ToString("F2", CultureInfo.InvariantCulture));
                    break;
                case 4:
                    valorTotal = quantidade * 2.00;
                    Console.WriteLine("Total: R$ " + valorTotal.ToString("F2", CultureInfo.InvariantCulture));
                    break;
                case 5:
                    valorTotal = quantidade * 1.50;
                    Console.WriteLine("Total: R$ " + valorTotal.ToString("F2", CultureInfo.InvariantCulture));
                    break;
            }
            /* Console.WriteLine("Total: R$ " + valorTotal.ToString("F2", CultureInfo.InvariantCulture)); */
        }
    }
}
