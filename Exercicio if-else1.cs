using System;
using System.Globalization;

namespace PrimeiroProjetoC{
    class Program{
        static void Main(string[] args)
        {
            int a, b, c, d;
            string[] valores = Console.ReadLine().Split(" ");
            a = int.Parse(valores[0]);
            b = int.Parse(valores[1]);
            c = int.Parse(valores[2]);
            d = int.Parse(valores[3]);
            if (b > c && d > a && a + b < c + d && c > 0 & d > 0 && a % 2 == 0) 
            {
                Console.WriteLine("VALORES ACEITOS");
            }
            else
            {
                Console.WriteLine("VALORES NAO ACEITOS");
            }
        }
    }
}
