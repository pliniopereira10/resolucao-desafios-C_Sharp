using System;
using System.Globalization;

namespace TiposDeTriangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            double valorDeA, valorDeB, valorDeC;
            double ladoUm, ladoDois, ladoTres;
            String [] valores;

            valores = Console.ReadLine().Split(' ');

            valorDeA = double.Parse(valores [0], CultureInfo.InvariantCulture);
            valorDeB = double.Parse(valores[1], CultureInfo.InvariantCulture);
            valorDeC = double.Parse(valores [2], CultureInfo.InvariantCulture);

           if (valorDeA > valorDeB && valorDeA > valorDeC) {
                ladoUm = valorDeA;

                if (valorDeB > valorDeC) {
                    ladoDois = valorDeB;
                    ladoTres = valorDeC; 

                }  else {
                    ladoDois = valorDeC;
                    ladoTres = valorDeB;
                }
                
            } else if (valorDeB > valorDeA && valorDeB > valorDeC) {
                ladoUm = valorDeB;
                
                if (valorDeA > valorDeC) {
                    ladoDois = valorDeA;
                    ladoTres = valorDeC; 

                }  else {
                    ladoDois = valorDeC;
                    ladoTres = valorDeA;

                }    
                

            } else {
                ladoUm = valorDeC;

                if (valorDeB > valorDeA) {
                    ladoDois = valorDeB;
                    ladoTres = valorDeA;
                    
                } else {
                    ladoDois = valorDeA;
                    ladoTres = valorDeB;
                }

            }

            if (ladoUm >= ladoDois + ladoTres) {
                Console.WriteLine("NAO FORMA TRIANGULO");

            }
            else {
                if (ladoUm * ladoUm == ladoDois * ladoDois + ladoTres * ladoTres) {
                    Console.WriteLine("TRIANGULO RETANGULO");

                }
                else if (ladoUm * ladoUm > ladoDois * ladoDois + ladoTres * ladoTres) {
                    Console.WriteLine("TRIANGULO OBTUSANGULO");

                }
                else {
                    Console.WriteLine("TRIANGULO ACUTANGULO");
                }

                
                if (ladoUm == ladoDois && ladoDois == ladoTres) {
                    Console.WriteLine("TRIANGULO EQUILATERO");

                }
                else if (ladoUm == ladoDois || ladoUm == ladoTres || ladoDois == ladoTres) {
                    Console.WriteLine("TRIANGULO ISOSCELES");

                }
            
            }
            
        }
    }
}
