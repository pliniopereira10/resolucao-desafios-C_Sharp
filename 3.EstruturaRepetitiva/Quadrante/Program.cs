using System;

namespace Quadrante
{
    class Program
    {
        static void Main(string[] args)
        {
            int coordX , coordY;
            string [] coordenadas;

            Console.WriteLine("Insira a coordenadas do plano cartesiano X e Y.");
            coordenadas = Console.ReadLine().Split(' ');

            coordX = int.Parse(coordenadas [0]);
            coordY = int.Parse(coordenadas [1]);

            while (coordX != 0 && coordY != 0 )
            {
                if (coordY > 0 && coordX > 0)
                {
                    Console.WriteLine("primeiro");
                    
                } else if (coordY > 0 && coordX < 0) {
                    Console.WriteLine("segundo");

                } else if (coordY < 0 && coordX < 0) {
                    Console.WriteLine("terceiro");

                } else {
                    Console.WriteLine("quarto");

                }

                Console.WriteLine("Insira a coordenadas do plano cartesiano X e Y.");
                coordenadas = Console.ReadLine().Split(' ');

                coordX = int.Parse(coordenadas [0]);
                coordY = int.Parse(coordenadas [1]);

            }

            Console.WriteLine();

        }
    }
}
