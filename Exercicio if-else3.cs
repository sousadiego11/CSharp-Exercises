using System;
using System.Globalization;

namespace PrimeiroProjetoC
{
    class Program
    {
        static void Main(string[] args)
        {
            //O programa irá utilizar o System.Globalization permitindo o uso de ponto ao invés de vírgula
            string[] notas = Console.ReadLine().Split(" ");
            double n1, n2, n3, n4, nEx, media;
            n1 = double.Parse(notas[0], CultureInfo.InvariantCulture);
            n2 = double.Parse(notas[1], CultureInfo.InvariantCulture);
            n3 = double.Parse(notas[2], CultureInfo.InvariantCulture);
            n4 = double.Parse(notas[3], CultureInfo.InvariantCulture);
            
            //O programa irá calcular a média do aluno e mostrar o resultado.
            media = (n1 * 2 + n2 * 3 + n3 * 4 + n4 * 1) / 10;
            Console.WriteLine("Media: " + media.ToString("F1", CultureInfo.InvariantCulture));

            if (media>=7.0)
            {
                Console.WriteLine("Aluno aprovado.");
            }
            else if (media<5.0)
            {
                Console.WriteLine("Aluno reprovado.");
            }
            else
            {
                Console.WriteLine("Aluno em exame.");
            }
            
            /*
            As condições a seguir são para o caso de o aluno ter ficado em exame.
            O programa irá pedir uma nota do exame final
            e logo em seguida mostrará os resultados de acordo com a nova média calculada.
            */          
            nEx = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Nota do exame:" + nEx.ToString("F1", CultureInfo.InvariantCulture));
            media = (media + nEx)/2;

            if (media >= 5.0)
            {
                Console.WriteLine("Aluno aprovado.");
                Console.WriteLine("Media final: " + media.ToString("F1", CultureInfo.InvariantCulture));
            }
            else
            {
                Console.WriteLine("Aluno reprovado.");
                Console.WriteLine("Media final: " + media.ToString("F1", CultureInfo.InvariantCulture));
            }
        }
    }
}