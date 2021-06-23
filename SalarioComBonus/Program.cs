using System;
using System.Globalization;

namespace SalarioComBonus
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome;
            double salarioFixo, salarioTotal, totalVendido;

            Console.Write("Nome do vendedor: ");
            nome = Console.ReadLine();

            Console.Write("Salário fixo: ");
            salarioFixo = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Total de vendas: ");
            totalVendido = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            salarioTotal = salarioFixo + (totalVendido * 0.15);

            Console.WriteLine("TOTAL = R$ " + salarioTotal.ToString("F2", CultureInfo.InvariantCulture));


        }
    }
}
