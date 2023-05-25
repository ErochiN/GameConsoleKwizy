using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameConsoleKwizy
{
    internal class MenuManagement
    {
        public string[] inventoryCells = new string[5];
        bool checkInventory;


        public MenuManagement()
        {
            for (int i = 0; i < inventoryCells.Length; i++)
            {
                inventoryCells[i] = "Пусто";
            }
        }

        public void ShowsInventory()
        {
            Console.SetCursorPosition(55, 0);
            Console.WriteLine("Инвентарь:");

            for (int i = 0; i < inventoryCells.Length; i++)
            {
                Console.SetCursorPosition(55, i + 1);
                Console.WriteLine(inventoryCells[i]);
            }
        }

        public void AddsToInventory(String subject) 
        {
            checkInventory = false;

            for (int i = 0; i < inventoryCells.Length; i++)
            {
                if (inventoryCells[i] == "Пусто") 
                {
                    inventoryCells[i] = subject;
                    checkInventory = true;
                }
            }
        }
    }
}
