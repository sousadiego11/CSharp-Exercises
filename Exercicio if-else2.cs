using System;
using System.Globalization;

namespace PrimeiroProjetoC
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 
            O Código a seguir indica o total a pagar pelo pedido no restaurante, 
            onde cada código representa um item e seu respectivo preço sendo multiplicado pela quantidade do item.
            */
            int codigo, quantidade;
            double preçoTotal;

            string[] valores = Console.ReadLine().Split(" ");
            codigo = int.Parse(valores[0], CultureInfo.InvariantCulture);
            quantidade = int.Parse(valores[1], CultureInfo.InvariantCulture);

            if (codigo == 1)
            {
                preçoTotal = quantidade * 4.00;
                Console.WriteLine("Total: R$ " + preçoTotal.ToString("F2", CultureInfo.InvariantCulture));
            }
            else if (codigo == 2)
            {
                preçoTotal = quantidade * 4.50;
                Console.WriteLine("Total: R$ " + preçoTotal.ToString("F2", CultureInfo.InvariantCulture));
            }
            else if (codigo == 3)
            {
                preçoTotal = quantidade * 5.00;
                Console.WriteLine("Total: R$ " + preçoTotal.ToString("F2", CultureInfo.InvariantCulture));
            }
            else if (codigo == 4)
            {
                preçoTotal = quantidade * 2.00;
                Console.WriteLine("Total: R$ " + preçoTotal.ToString("F2", CultureInfo.InvariantCulture));
            }
            else if (codigo == 5)
            {
                preçoTotal = quantidade * 1.50;
                Console.WriteLine("Total: R$ " + preçoTotal.ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}
