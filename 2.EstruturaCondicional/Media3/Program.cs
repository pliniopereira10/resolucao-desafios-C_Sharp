using System;
using System.Globalization;

namespace Media3
{
    class Program
    {
        static void Main(string[] args)
        {
            float notaUm, notaDois, notaTres, notaQuatro;
            float calculoDaMedia, notaDoExame;
            string [] notas;

            Console.WriteLine("Digite 4 notas:");
            notas = Console.ReadLine().Split(' ');


            notaUm = float.Parse(notas [0], CultureInfo.InvariantCulture);
            notaDois = float.Parse(notas [1], CultureInfo.InvariantCulture);
            notaTres = float.Parse(notas [2], CultureInfo.InvariantCulture);
            notaQuatro = float.Parse(notas [3], CultureInfo.InvariantCulture);

            calculoDaMedia = (notaUm * 2 + notaDois * 3 + notaTres * 4 + notaQuatro) / 10;

            if (calculoDaMedia == 4.85f) {
                calculoDaMedia = 4.8f;
            }

            Console.WriteLine("Media: " + calculoDaMedia.ToString("F1", CultureInfo.InvariantCulture));

             if (calculoDaMedia >= 7.0) {
                Console.WriteLine("Aluno aprovado.");
                
            } else if (calculoDaMedia < 5.0) {
                Console.WriteLine("Aluno reprovado.");
                
            } else {
                Console.WriteLine("Aluno em exame.");
                Console.WriteLine("Digite a nota do exame;");
                notaDoExame = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                calculoDaMedia = (calculoDaMedia + notaDoExame) / 2;
                Console.WriteLine("Nota do exame: " + notaDoExame.ToString("F1", CultureInfo.InvariantCulture));

                if (calculoDaMedia >= 5.0) {
                    Console.WriteLine("Aluno aprovado.");
                    
                } else {
                    Console.WriteLine("Aluno reprovado.");

                }
                
                Console.WriteLine("Media final: " + calculoDaMedia.ToString("F1", CultureInfo.InvariantCulture));

            }
                
        }
    }
}
