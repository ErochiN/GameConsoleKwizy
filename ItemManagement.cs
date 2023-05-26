using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameConsoleKwizy
{
    internal class ItemManagement : MenuManagement
    {
        public void picksUpItem() 
        {
            switch (playerPositionX, playerPositionY, levelNumber, maps)
            {
                case var n when (playerPositionX == 9 && playerPositionY == 8 && levelNumber == 1 && maps[playerPositionY, playerPositionX] == 'X'):
                    Console.SetCursorPosition(55, 7);
                    Console.Write("Нож");
                    Console.SetCursorPosition(55, 8);
                    Console.Write("Q - Подобрать");
                    Console.SetCursorPosition(55, 9);
                    Console.Write("E - Оставить");

                    ConsoleKeyInfo keyInfo = Console.ReadKey();

                    if (keyInfo.Key == ConsoleKey.Q) 
                    {
                        AddsToInventory("Нож");
                        maps[playerPositionY, playerPositionX] = 'O';
                    }
                    
                    break;
            }
        }
    }
}
