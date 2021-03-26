using System;
using System.Globalization;
namespace Salario {
    class Program {
        static void Main(string[] args) {
            //EXERCICIO SALARIO
            
            int num;
            double salario, hrt, vht;
            num = int.Parse(Console.ReadLine());
            hrt = double.Parse(Console.ReadLine());
            vht = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            salario = hrt * vht;
            Console.WriteLine("NUMBER = " + num);
            Console.WriteLine("SALARY = U$ " + salario.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
