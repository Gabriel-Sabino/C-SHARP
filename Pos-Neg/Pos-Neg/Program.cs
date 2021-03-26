using System;

namespace Pos_Neg
{
    class Program
    {
        static void Main(string[] args)
        {
            //NUMERO NEGATIVO OU POSITIVO
            Console.WriteLine("Digite um numero:");
            double x = double.Parse(Console.ReadLine());
            if (x < 0)
            {
                Console.WriteLine("Negativo");
            }
            else
            {
                Console.WriteLine("Positivo");
            }
        }
    }
}
