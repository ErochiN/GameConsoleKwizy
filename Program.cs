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
            ClickHandling clickHandling = new ClickHandling();
            bool cycleWork = true;
            clickHandling.ShowsMap();

            while (cycleWork)
            {
                clickHandling.ShowsMap();
                clickHandling.OutputCoordinates();

                Console.SetCursorPosition(clickHandling.playerPositionX, clickHandling.playerPositionY);
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("@");
                clickHandling.MovesPlayer();

                
            }
        }
    }
}
