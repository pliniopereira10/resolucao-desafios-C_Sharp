using System;
using System.Globalization;

namespace CoordDeUmPonto
{
    class Program
    {
        static void Main(string[] args)
        {
            double valorDeX, valorDeY;
            String [] valores;

            Console.WriteLine("Digite dois valores:");
            valores = Console.ReadLine().Split(' ');

            valorDeX = double.Parse(valores [0], CultureInfo.InvariantCulture);
            valorDeY = double.Parse(valores [1], CultureInfo.InvariantCulture);


            if (valorDeX == 0 && valorDeY == 0) {
                Console.WriteLine("Origem");
                
            } else if ( valorDeX == 0) {
                Console.WriteLine("Eixo X");
            
            } else if (valorDeY == 0) {
                Console.WriteLine("Eixo Y");

            } else if (valorDeY > 0 && valorDeX > 0) {
                Console.WriteLine("Q1");
                
            } else if (valorDeY > 0 && valorDeX < 0){
                Console.WriteLine("Q2");

            } else if (valorDeY < 0 && valorDeX < 0) {
                Console.WriteLine("Q3");

            } else {
                Console.WriteLine("Q4");                

            }
        }
    }
}
