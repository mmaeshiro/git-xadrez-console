using System;
using Tabuleiro;

namespace Xadrez_Console
{
    class Program
    {
        static void Main(string[] args)
        {

            Tabuleiro.Tabuleiro tab = new Tabuleiro.Tabuleiro(8, 8);

            Posicao P;

            P = new Posicao(3, 4);

            Console.WriteLine("Posição: " + P);

            Console.ReadLine();
        }
    }
}
