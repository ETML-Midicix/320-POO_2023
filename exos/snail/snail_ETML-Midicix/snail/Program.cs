using System;
using System.Threading;
namespace snail
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string snailAlive = "_@_ö";
            string snailDead = "____";
            int energy = 50;
            int posX = 0;
            int posY = 10;
            int time = 250;

            Console.ForegroundColor = ConsoleColor.Green;
            int i = 0;

            while (i < energy)
            {
                if (Convert.ToDecimal(i) / Convert.ToDecimal(energy) >= Convert.ToDecimal(9) / Convert.ToDecimal(10))
                {
                    time = 1200;
                }
                Console.SetCursorPosition(posX, posY);
                Console.WriteLine(snailAlive);
                Thread.Sleep(time);
                Console.Clear();
                i++;
                posX = i;
            }

            Console.SetCursorPosition(posX, posY);
            Console.WriteLine(snailDead);
            Console.ResetColor();
        }
    }
}