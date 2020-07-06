using System;
using System.Globalization;

namespace Vetores001
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double media = 0.0;
            string[] vet = Console.ReadLine().Split(" ");
            double[] valores = new double[n];
            for (int i = 0; i<n; i++)
            {
                valores[i] = double.Parse(vet[i], CultureInfo.InvariantCulture);
                media += valores[i];
            }
            media /= n;
            Console.WriteLine(media.ToString("F3",CultureInfo.InvariantCulture));
            for (int i = 0; i < n; i++)
            {
                if (valores[i] < media)
                {
                    Console.WriteLine(valores[i].ToString("F1", CultureInfo.InvariantCulture));
                }
            }
        }
    }
}
