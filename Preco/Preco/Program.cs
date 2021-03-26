using System;
using System.Globalization;
namespace Preco {
    class Program {
        static void Main(string[] args) {
            //PRECO
            double codp1, codp2, nump1, nump2, preco1, preco2, p1, p2, total;

            codp1 = double.Parse(Console.ReadLine());
            nump1 = double.Parse(Console.ReadLine());
            preco1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            codp2 = double.Parse(Console.ReadLine());
            nump2 = double.Parse(Console.ReadLine());
            preco2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            p1 = nump1 * preco1;
            p2 = nump2 * preco2;
            total = p1 + p2;
            Console.WriteLine("VALOR A PAGAR: " + total.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
