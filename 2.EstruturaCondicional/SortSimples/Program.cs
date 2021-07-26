using System;

namespace SortSimples
{
    class Program
    {
        static void Main(string[] args)
        {
            string [] valores;
            int valorUm, valorDois, valorTres;
            int primeiro, segundo, terceiro;

            Console.WriteLine("Informe três valores:");
            valores = Console.ReadLine().Split(' ');

            valorUm = int.Parse(valores [0]);
            valorDois = int.Parse(valores [1]);
            valorTres = int.Parse(valores [2]);

            if ( valorUm < valorDois && valorUm < valorTres) {
                primeiro = valorUm;
                if ( valorDois < valorTres){
                    segundo = valorDois;
                    terceiro = valorTres;

                } else {
                    segundo = valorTres;
                    terceiro = valorDois;

                }

            } else if (valorDois < valorUm && valorDois < valorTres) {
                primeiro = valorDois;
                if ( valorUm < valorTres) {
                    segundo = valorUm;
                    terceiro = valorTres;

                } else {
                    segundo = valorTres;
                    terceiro = valorUm;

                }
                
            } else {
                primeiro = valorTres;
                if (valorUm < valorDois) {
                    segundo = valorUm;
                    terceiro = valorDois;

                } else {
                   segundo = valorDois;
                   terceiro = valorUm; 
                }

            }

            Console.WriteLine(primeiro);
            Console.WriteLine(segundo);
            Console.WriteLine(terceiro);
            Console.WriteLine();
            Console.WriteLine(valorUm);
            Console.WriteLine(valorDois);
            Console.WriteLine(valorTres);

        }
    }
}
