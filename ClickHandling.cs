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
        public int playerPositionX = 2, playerPositionY = 2;

        public void MovesPlayer()
        {
            ConsoleKeyInfo keyInfo = Console.ReadKey();

            switch (keyInfo.Key)
            {
                case ConsoleKey.W:
                    if (maps[playerPositionY - 1, playerPositionX] != '#')
                    {
                        playerPositionY--;
                    }
                    break;
                case ConsoleKey.S:
                    if (maps[playerPositionY + 1, playerPositionX] != '#')
                    {
                        playerPositionY++;
                    }
                    break;
                case ConsoleKey.D:
                    if (maps[playerPositionY, playerPositionX + 1] != '#')
                    {
                        playerPositionX++;
                    }
                    break;
                case ConsoleKey.A:
                    if (maps[playerPositionY, playerPositionX - 1] != '#')
                    {
                        playerPositionX--;
                    }
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
                    Console.ForegroundColor = ConsoleColor.White;

                    if (maps[i, j] == 'П' || maps[i, j] == 'X')
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                    }

                    if (maps[i, j] == 'O')
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                    }

                    Console.Write(maps[i, j]);
                }
                Console.WriteLine();
            }

        }

        public void OutputCoordinates()
        {

            Console.SetCursorPosition(45, 0);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("X = " + playerPositionX);
            Console.SetCursorPosition(45, 1);
            Console.Write("Y = " + playerPositionY);
            

        }
    }
}
