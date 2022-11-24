using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace NettButikk
{
    internal class Product
    {

        public void DisplayItemStol()
        {
            
            WriteLine("==============================================");
            WriteLine("PRODUKTER");
            sellItem("a) Elkjøp Gamingstol", 2000, "Flott rød og svar gamingstol fra elkjøp!");
            sellItem("b) IKEA Kontorstol", 1100, "Helt vanlig svart kontorstol fra IKEA som funker flott for skolen!");
            WriteLine("==============================================");
        }

    
        public void DisplayItemBord()
        {


            WriteLine("==============================================");
            WriteLine("PRODUKTER");
            sellItem("a) IKEA Skrivebord", 150, "Den er litt whack lowkey men den funker");
            sellItem("b) JYSK Spisebord", 500, "Den er flott for hele familien!");
            WriteLine("==============================================");
        }

        public void DisplayItemGarderobeSkap()
        {
            WriteLine("==============================================");
            WriteLine("PRODUKTER");
            sellItem("a) PAX skap", 1550, "Stor å fin garderobeskap med skyvedører");
            sellItem("b) IKEA Skap", 750, "Stor dobbedør skap for alle dine flotte klær!");
            WriteLine("==============================================");

        }

        public void DisplayItemSofa()
        {
            WriteLine("==============================================");
            WriteLine("PRODUKTER");
            sellItem("a) Scandinavian Sofa", 5600, "Behagelig 3 seters sofa laget med ekte skandinavisk kamel");
            sellItem("b) IKEA Sofa", 3500, "Flott 5 personers sofa som er laget av flott skinn");
            WriteLine("==============================================");
        }

        private void sellItem(string itemName, int cost, string beskrivelse)
        {
            WriteLine($"Navn: {itemName}\nPris: {cost} \nBeskrivelse: {beskrivelse}");

        }

    }
}
