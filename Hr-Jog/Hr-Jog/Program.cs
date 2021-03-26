using System;

namespace Hr_Jog
{
    class Program
    {
        static void Main(string[] args)
        {
            //HORAS JOGADAS
            string[] valores = Console.ReadLine().Split(' ');
            int hInicial = int.Parse(valores[0]);
            int hFinal = int.Parse(valores[1]);

            int duracao;
            if (hInicial < hFinal)
            {
                duracao = hFinal - hInicial;
            }
            else
            {
                duracao = 24 - hInicial + hFinal;
            }
            Console.WriteLine($"O JOGO DUROU: {duracao} HORA(S).");
        }
    }
}
