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
            if (playerPositionX == 5 && playerPositionY == 5)
            {
                MessageBox.Show("ALL OK");
            }
        }
    }
}
