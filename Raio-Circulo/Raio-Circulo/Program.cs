using System;
using System.Globalization;
namespace Raio_Circulo {
    class Program {
        static void Main(string[] args) {
            //EXERCICIO RAIO DO CIRCULO
            
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double pi = 3.14159;
            double area = pi * raio * raio;
            Console.WriteLine("O valor da Área do Circulo é: " + area.ToString("F4", CultureInfo.InvariantCulture));
        }
    }
}
