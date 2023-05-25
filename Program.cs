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

            bool cycleWork = true;

            Console.CursorVisible = false;

            while (cycleWork)
            {
                levelTransition.ShowsMap();
                levelTransition.OutputCoordinates();

                Console.SetCursorPosition(levelTransition.playerPositionX, levelTransition.playerPositionY);
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("@");
                levelTransition.MovesPlayer();

                levelTransition.SwitchLevel();
            }
        }
    }
}
