using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameConsoleKwizy
{
    internal class LevelTransition : ClickHandling
    {
        int levelNumber = 1;

        public void SwitchLevel() 
        {
            switch (playerPositionX, playerPositionY, levelNumber)
            {
                case var n when (playerPositionX == 39 && playerPositionY == 7 && levelNumber == 1):
                    maps = mapLevel2;
                    playerPositionX = 2;
                    levelNumber = 2;
                    break;
            }
        }
    }
}
