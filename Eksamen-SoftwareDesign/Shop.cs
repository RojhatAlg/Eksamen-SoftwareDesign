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
        }

        private void sellItem()
        {

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
