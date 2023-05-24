using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameConsoleKwizy
{
    internal class ClickHandling : Maps
    {
        public char[,] maps = mapLevel1;
        public int playerPositionX, playerPositionY;

        public void MovesPlayer() 
        {
            ConsoleKeyInfo keyInfo = Console.ReadKey();

            switch (keyInfo.Key)
            {
                case ConsoleKey.W:
                    break;
                case ConsoleKey.S:
                    break;
                case ConsoleKey.D:
                    break;
                case ConsoleKey.A:
                    break;
            }
        }

        public void ShowsMap()
        {
            Console.Clear();
            Console.SetCursorPosition(0, 0);

            for (int i = 0; i < maps.GetLength(0); i++)
            {
                for (int j = 0; j < maps.GetLength(1); j++)
                {
                    Console.Write(maps[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}
