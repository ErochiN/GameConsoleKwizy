using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameConsoleKwizy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LevelTransition levelTransition = new LevelTransition();
            MenuManagement menuManagement = new MenuManagement();

            bool cycleWork = true;

           

            while (cycleWork)
            {
                Console.CursorVisible = false;
                levelTransition.ShowsMap();
                levelTransition.OutputCoordinates();
                menuManagement.ShowsInventory();

                Console.SetCursorPosition(levelTransition.playerPositionX, levelTransition.playerPositionY);
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("@");
                levelTransition.MovesPlayer();

                levelTransition.SwitchLevel();
            }
        }
    }
}
