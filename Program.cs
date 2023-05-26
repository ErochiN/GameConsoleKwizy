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
            ControlCenter controlCenter = new ControlCenter();

            bool cycleWork = true;

            Console.WriteLine("НАЖМИТЕ ЛЮБУЮ КЛАВИШУ");
            Console.ReadKey();

            while (cycleWork)
            {
                Console.CursorVisible = false;

                controlCenter.ShowsMap();
                controlCenter.OutputCoordinates();
                controlCenter.ShowsInventory();
                controlCenter.picksUpItem();

                Console.SetCursorPosition(controlCenter.playerPositionX, controlCenter.playerPositionY);
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("@");
                controlCenter.MovesPlayer();

                controlCenter.SwitchLevel();
            }
        }
    }
}
