// Programa soma a quantidade total de experimentos e mostra a proporção

using System;
using System.Globalization;

namespace Experiencias
{
    class Program
    {
        static void Main(string[] args)
        {
            int qteTestes;
            string [] experimentos;
            double qtdExperimentos, qtdCoelhos, qtdRatos, qtdSapos;
            char tipoCobaias;
            double qtdTotalExp; 
            double propExpCoelhos, propExpRatos, propExpSapos; 

            qtdCoelhos = 0;
            qtdRatos = 0;
            qtdSapos = 0;

            Console.WriteLine("Insira quantos testes serão informados.");
            qteTestes = int.Parse(Console.ReadLine());

            Console.WriteLine("Insira a quantidade e qual cobaia.");
            Console.WriteLine("C = coelho / R = rato / S = sapo");
            
            for (int cont = 0; cont < qteTestes; cont++)
            {
                experimentos = Console.ReadLine().Split(' ');

                qtdExperimentos = int.Parse(experimentos [0], CultureInfo.InvariantCulture);
                tipoCobaias = char.Parse(experimentos [1]);
                
                if (qtdExperimentos >= 1 && qtdExperimentos <= 15)
                {
                    if (tipoCobaias == 'C')
                    {
                        qtdCoelhos += qtdExperimentos;

                    } else if (tipoCobaias == 'R')
                    {
                        qtdRatos += qtdExperimentos;

                    } else if (tipoCobaias == 'S')
                    {
                        qtdSapos += qtdExperimentos;
                    }
                }
            }

            qtdTotalExp = qtdCoelhos  + qtdRatos + qtdSapos;
            propExpCoelhos = (qtdCoelhos / qtdTotalExp) * 100;
            propExpRatos = (qtdRatos / qtdTotalExp * 100);
            propExpSapos = (qtdSapos / qtdTotalExp * 100);

            Console.WriteLine("Total: " + qtdTotalExp + " cobaias");
            Console.WriteLine("Total de coelhos: " + qtdCoelhos);
            Console.WriteLine("Total de ratos: " + qtdRatos);
            Console.WriteLine("Total de sapos: " + qtdSapos);
            Console.Write("Percentual de coelhos: ");
            Console.WriteLine(propExpCoelhos.ToString("F2", CultureInfo.InvariantCulture) + " %");
            Console.Write("Percentual de ratos: ");
            Console.WriteLine(propExpRatos.ToString("F2", CultureInfo.InvariantCulture) + " %");
            Console.Write("Percentual de sapos: ");
            Console.WriteLine(propExpSapos.ToString("F2", CultureInfo.InvariantCulture) + " %");

        }
    }
}
