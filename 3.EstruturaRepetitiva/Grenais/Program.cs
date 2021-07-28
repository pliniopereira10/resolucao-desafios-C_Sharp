using System;

namespace Grenais
{
    class Program
    {
        static void Main(string[] args)
        {
            int golsGremio, golsInter, grenais, vitoriaGremio, vitoriaInter, empates, novoGrenal;
            string [] gols;

            vitoriaInter = 0;
            vitoriaGremio = 0;
            grenais = 0;
            empates = 0;
            novoGrenal = 1;

                Console.WriteLine("\tMaior vitorioso");
                Console.WriteLine("\tInter ou Gremio");

            while (novoGrenal == 1) {

                Console.WriteLine("Informe gols Inter X Gremio");
                gols = Console.ReadLine().Split(' ');
                golsInter = int.Parse(gols [0]);
                golsGremio = int.Parse(gols [1] );
                grenais ++;

                if (golsInter > golsGremio) {

                    vitoriaInter ++;

                } else if (golsGremio > golsInter) {

                    vitoriaGremio ++;
                    
                } else {

                    empates ++;

                }

                Console.WriteLine("Novo grenal (1-sim 2-nao)");
                novoGrenal = int.Parse(Console.ReadLine());

            }

            Console.WriteLine(grenais + " grenais");
            Console.WriteLine("Inter:" + vitoriaInter);
            Console.WriteLine("Gremio:" + vitoriaGremio);
            Console.WriteLine("Empates:" + empates);

            if (vitoriaInter == vitoriaGremio) {

                Console.WriteLine("Nao houve vencedor");
                
            } else if (vitoriaInter > vitoriaGremio) {

                Console.WriteLine("Inter venceu mais");

            } else {

                Console.WriteLine("Gremio venceu mais");

            }

        }
    }
}
