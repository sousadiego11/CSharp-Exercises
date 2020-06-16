using System;
using System.Globalization;

namespace Vetores001
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] nome = new string[n];
            int[] idade = new int[n];
            double[] altura = new double[n];
            
            // Leitura dos dados
            for (int i = 0; i<n; i++)
            {
                string[] elementos = Console.ReadLine().Split(" ");
                nome[i] = elementos[0];
                idade[i] = int.Parse(elementos[1]);
                altura[i] = double.Parse(elementos[2], CultureInfo.InvariantCulture);
            }
            // Calculo da altura média entre as pessoas
            double alturaMedia = 0.0;
            for (int i = 0; i < n; i++)
            {
                alturaMedia += altura[i];
            }
            alturaMedia /= n;
            Console.WriteLine("Altura media: " + alturaMedia.ToString("F2", CultureInfo.InvariantCulture));
            
            // Porcentagem de pessoas menores de 16 anos
            double qntIdade = 0;
            for (int i = 0; i < n; i++)
            {
                if (idade[i] < 16)
                {
                    qntIdade++;
                }
            }
            double mediaIdade = qntIdade / n * 100.0;
            Console.Write("Pessoas com menos de 16 anos: " + mediaIdade.ToString("F1", CultureInfo.InvariantCulture) + "%");
        }
    }
}
