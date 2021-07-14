using System;
using System.Globalization;

namespace AumentoDeSalario
{
    class Program
    {
        static void Main(string[] args)
        {
            double ganho, salarioAntigo, novoSalario;
            String percentualReajuste;
                        
            Console.Write("********************");
            Console.WriteLine("********************");
            Console.WriteLine("\tTabela de Reajuste Salarial");
            Console.Write("********************");
            Console.WriteLine("********************");

            Console.WriteLine("    Salário\t  Percentual de Reajuste");
            Console.WriteLine("   0 - 400.00\t\t\t15%");
            Console.WriteLine("  400.01 - 800.00\t\t12%");
            Console.WriteLine(" 800.01 - 1200.00\t\t10%");
            Console.WriteLine("1200.01 - 2000.00\t\t7%");
            Console.WriteLine(" Acima de 2000.00\t\t4%");
            Console.Write("********************");
            Console.WriteLine("********************");

            Console.WriteLine("Digite valor do salário antigo:");
            salarioAntigo = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (salarioAntigo > 0 && salarioAntigo <= 400.00) {
                novoSalario = salarioAntigo + (salarioAntigo * 0.15);
                ganho = salarioAntigo * 0.15;
                percentualReajuste = "15 %";

            } else if (salarioAntigo > 400.00 && salarioAntigo <= 800.00) {
                novoSalario = salarioAntigo + (salarioAntigo * 0.12);
                ganho = salarioAntigo * 0.12;
                percentualReajuste = "12 %";
                
            } else if (salarioAntigo > 800.00 && salarioAntigo <= 1200.00) {
                novoSalario = salarioAntigo + (salarioAntigo * 0.1);
                ganho = salarioAntigo * 0.1;
                percentualReajuste = "10 %";

            } else if (salarioAntigo > 1200.00 && salarioAntigo <= 2000.00) {
                novoSalario = salarioAntigo + (salarioAntigo * 0.07);
                ganho = salarioAntigo * 0.07;
                percentualReajuste = "7 %";

            } else {
                novoSalario = salarioAntigo + (salarioAntigo * 0.04);
                ganho = salarioAntigo * 0.04;
                percentualReajuste = "4 %";
            }

            Console.WriteLine("Novo salario: " + novoSalario.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Reajuste ganho: " + ganho.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Em percentual: " + percentualReajuste);
        }
    }
}
