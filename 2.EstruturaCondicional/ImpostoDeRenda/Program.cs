using System;
using System.Globalization;

namespace ImpostoDeRenda
{
    class Program
    {
        static void Main(string[] args)
        {
            double salario, imposto;

            Console.Write("******************************");
            Console.WriteLine("********************");
            Console.Write(" Renda\t\t");
            Console.WriteLine("\t\tImposto de Renda");

            Console.Write(" de 0.00 a R$ 2000.00\t\t");
            Console.WriteLine("      Isento");
            Console.Write(" de 2000.01 até R$ 3000.00\t");
            Console.WriteLine("\t8%");
            Console.Write(" de 3000.01 até R$ 4500.00\t");
            Console.WriteLine("\t18%");
            Console.Write(" acima de R$ 4500.00\t\t");
            Console.WriteLine("\t28%");
            Console.Write("******************************");
            Console.WriteLine("********************");

            salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            
            if (salario <= 2000.00){
                Console.WriteLine("Isento");

            } else if (salario > 2000.00 && salario <= 4500.00){
                if (salario >= 2000.01 && salario <= 3000.00) {
                    imposto = salario - 2000.00;
                    imposto *= 0.08;
                    Console.WriteLine("R$ " + imposto.ToString("F2", CultureInfo.InvariantCulture));

                } else {
                    imposto = salario - 3000.00;
                    imposto = imposto * 0.18 + 80.00;
                    Console.WriteLine("R$ " + imposto.ToString("F2", CultureInfo.InvariantCulture));

                }

            } else {
                imposto = salario - 4500.00;
                imposto = imposto * 0.28 + 350.00;
                 Console.WriteLine("R$ " + imposto.ToString("F2", CultureInfo.InvariantCulture));

            }
            
        }
    }
}
