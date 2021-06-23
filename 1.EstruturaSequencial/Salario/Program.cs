using System;
using System.Globalization;

namespace Salario
{
    class Program
    {
        static void Main(string[] args)
        {
            int matriculaFuncionarios, horasTrabalhada;
            double valorDaHora, salario;

            Console.Write("Digite à matrícula: ");
            matriculaFuncionarios = int.Parse(Console.ReadLine());

            Console.Write("Digite quantidade de horas trabalhada: ");
            horasTrabalhada = int.Parse(Console.ReadLine());

            Console.Write("Digite valor da hora trabalhada: ");
            valorDaHora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            salario = valorDaHora * horasTrabalhada;

            Console.WriteLine("NUMBER = " + matriculaFuncionarios);
            Console.WriteLine("SALARY = U$ " + salario.ToString("F2", CultureInfo.InvariantCulture));





        }
    }
}
