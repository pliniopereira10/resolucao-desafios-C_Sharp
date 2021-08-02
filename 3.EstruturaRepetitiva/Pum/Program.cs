// Programa lê um valor inteiro N. Este N é a quantidade de linhas de saída que serão 
// apresentadas na execução do programa.

using System;

namespace Pum
{
    class Program
    {
        static void Main(string[] args)
        {
            int numLinhas, contUm, contDois, contTres, contQuatro;
            contTres = 1;
            contQuatro = 3;

            numLinhas = int.Parse(Console.ReadLine());

            for (contUm = numLinhas; contUm > 0; contUm--) {

                for (contDois = contTres; contDois <= contQuatro; contDois++)
                {
                    Console.Write(contDois + " ");
                }
                contTres = contDois + 1;
                contQuatro = contTres + 2;
                Console.WriteLine("PUM");
            }
        }
    }
}
