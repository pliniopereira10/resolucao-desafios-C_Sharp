// Programa lê um valor inteiro N, que é a quantidade de casos de teste.
// Cada caso de teste consiste de dois inteiros X e Y. 
// Posteriormente executa a soma de Y ímpares consecutivos a partir de X inclusive o
// próprio X se ele for ímpar. 

using System;

namespace SomaImparesConsecutivos
{
    class Program
    {
        static void Main(string[] args)
        {
            int qtdTestes, valorX, valorY, soma, primInd, segInd, tercInd;
            string [] valores;


            qtdTestes = int.Parse(Console.ReadLine());

            for (primInd = 0; primInd < qtdTestes; primInd++)
            {
                valores = Console.ReadLine().Split(' ');
                valorX = int.Parse(valores [0]);
                valorY = int.Parse(valores [1]);

                soma = 0;
                tercInd = 0;
                for (segInd = valorX; tercInd < valorY; segInd++)
                {
                    if (segInd % 2 != 0) {
                            soma += segInd;
                            tercInd += 1; 

                    }

                }
                Console.WriteLine(soma);

            }
        }
    }
}
