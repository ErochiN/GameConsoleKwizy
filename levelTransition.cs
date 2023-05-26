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
        public int levelNumber = 1;

        public void SwitchLevel() 
        {
            switch (playerPositionX, playerPositionY, levelNumber)
            {
                //Control level 1
                case var n when (playerPositionX == 39 && playerPositionY == 7 && levelNumber == 1):
                    maps = mapLevel2;
                    playerPositionX = 2;
                    levelNumber = 2;
                    break;

            //Control level2
                //Up level 1
                case var n when (playerPositionX == 1 && playerPositionY == 7 && levelNumber == 2):
                    maps = mapLevel1;
                    playerPositionX = 38;
                    levelNumber = 1;
                    break;
            }
        }
    }
}
