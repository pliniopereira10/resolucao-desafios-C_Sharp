using System;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            int qtdValores, valorX, valorY, soma;
            valorX = 0;
            valorY = 1;
            soma = 0;
            

            qtdValores = int.Parse(Console.ReadLine());

            for (int cont = 0; cont < qtdValores; cont++)
            {
                if (cont == qtdValores -1)
                {
                    Console.WriteLine(valorX) ;

                } else {
                    Console.Write(valorX + " ") ;

                }
                
                soma = valorY;
                valorY = valorX;
                valorX = soma + valorY;
                

            }
        }
    }
}
