using System;
using System.Globalization;
namespace area_formas {
    class Program {
        static void Main(string[] args) {
            // AREA GEOMETRICA
            string[] valor = Console.ReadLine().Split(' ');
            double a = double.Parse(valor[0], CultureInfo.InvariantCulture);
            double b = double.Parse(valor[1], CultureInfo.InvariantCulture);
            double c = double.Parse(valor[2], CultureInfo.InvariantCulture);

            double triangulo = a * c / 2.0;
            double circulo = 3.14159 * c * c;
            double trapezio = (a + b) / 2.0 * c;
            double quadrado = b * b;
            double retangulo = a * b;

            Console.WriteLine("TRIANGULO: " + triangulo.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("CIRCULO: " + circulo.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("TRAPEZIO: " + trapezio.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("QUADRADO: " + quadrado.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("RETANGULO: " + retangulo.ToString("F3", CultureInfo.InvariantCulture));
        }
    }
}
