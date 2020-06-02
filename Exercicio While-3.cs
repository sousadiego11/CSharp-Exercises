using System;
using System.Globalization;

namespace EstruturasRepetitivas
{
    class Program
    {
        static void Main(string[] args)
        {
            int idade, quantidade;
            double media;
            idade = int.Parse(Console.ReadLine());
            media = 0.0;
            quantidade = 0;
            
            while (idade >= 0)
            {
                media += idade;
                quantidade++;
                idade = int.Parse(Console.ReadLine());
            }
            
            media = media / quantidade;
            Console.WriteLine(media.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
