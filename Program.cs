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

            while (cycleWork)
            {
                levelTransition.ShowsMap();
                clickHandling.OutputCoordinates();

                Console.SetCursorPosition(clickHandling.playerPositionX, clickHandling.playerPositionY);
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("@");
                clickHandling.MovesPlayer();

                levelTransition.SwitchLevel();
            }
        }
    }
}
