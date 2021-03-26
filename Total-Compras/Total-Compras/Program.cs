using System;
using System.Globalization
namespace Total_Compras
{
    class Program
    {
        static void Main(string[] args)
        {
            //TOTAL DE COMPRAS
            string[] valores = Console.ReadLine().Split(' ');
            int code = int.Parse(valores[0]);
            int quant = int.Parse(valores[1]);
            double total;

            if (code == 1)
            {
                total = quant * 4.00;
            }
            else if (code == 2)
            {
                total = quant * 4.50;
            }
            else if (code == 3)
            {
                total = quant * 5.00;
            }
            else if (code == 4)
            {
                total = quant * 2.00;
            }
            else
            {
                total = quant * 1.50;
            }
            Console.WriteLine("Total: " + total.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
