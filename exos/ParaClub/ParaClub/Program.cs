using System;
using System.Threading;

namespace ParaClub
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.SetBufferSize(Config.SCREEN_WIDTH, Config.SCREEN_HEIGHT);
            Console.CursorVisible = false;

            Plane plane = new Plane();

            Para Bob = new Para();

            plane.draw();

            bool check = true;

            while (check)
            {
                // Modifier le modèle (ce qui *est*)
                plane.update();

                // Modifier ce que l'on *voit*
                Console.Clear();
                plane.draw();

                // Temporiser
                Thread.Sleep(100);

                if (Console.KeyAvailable) // L'utilisateur a pressé une touche
                {
                    ConsoleKeyInfo keyPressed = Console.ReadKey(false);
                    switch (keyPressed.Key)
                    {
                        case ConsoleKey.Escape:
                            check = false;
                            break;
                        case ConsoleKey.Spacebar:
                            Bob.dive(plane.isHere());
                            check = false;
                            break;
                    }
                }
            }
        }
    }
}