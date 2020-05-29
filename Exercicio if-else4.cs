using System;
using System.Globalization;

namespace PrimeiroProjetoC
{
    class Program
    {
        static void Main(string[] args)
        {
            //objetivo do projeto é determinar em qual quadrante se localiza o ponto com as coordenadas X e Y.
            double x, y;
            string[] coordenadas = Console.ReadLine().Split(" ");
            x = double.Parse(coordenadas[0], CultureInfo.InvariantCulture);
            y = double.Parse(coordenadas[1], CultureInfo.InvariantCulture);

            if (x > 0.0 && y > 0.0) {Console.WriteLine("Q1");}
            else if (x < 0.0 && y > 0.0) {Console.WriteLine("Q2");}
            else if (x < 0.0 && y < 0.0) {Console.WriteLine("Q3");}
            else if (x > 0.0 && y < 0.0) {Console.WriteLine("Q4");}
            else { Console.WriteLine("Origem");}

        }
    }
}
