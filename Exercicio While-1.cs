using System;
using System.Globalization;

namespace EstruturasRepetitivas
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            int soma = 0;
            while (x != 0)
            {
                soma += x;
                x = int.Parse(Console.ReadLine());
            }
            Console.WriteLine(soma);
            Console.ReadLine();
        }
    }
}
