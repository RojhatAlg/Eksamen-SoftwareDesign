using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace NettButikk
{
    class Shop
    {
        public void run()
        {
            // Shop logic
            DisplayIntro();
            DisplayOutro();
        }

        private void DisplayIntro()
        {
            WriteLine("==============================================");
            WriteLine("KATEGORI:");
            WriteLine("==============================================");
            sellItem("Stol", 500);
        }

        private void sellItem(string itemName, int cost)
        {
            WriteLine($"Vil du kjøpe denne flotte stolen {itemName} for {cost} ?");

        }

        private void DisplayOrderTotal()
        {

        }

        private void DisplayOutro()
        {
            WriteLine("Thanks for shopping!");
            WriteLine("Press any key to exit...");
            ReadKey();
        }
    }
}
