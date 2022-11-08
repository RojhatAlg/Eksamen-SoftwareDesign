using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace NettButikk
{
    internal class Produkt
    {


        public void DisplayItemStol()
        {
            WriteLine("==============================================");
            WriteLine("STOLER");
            WriteLine("Asus gamingstol", 100, "Veldig Behagelig stol for gaming");
            WriteLine("==============================================");
        }

    
        public void DisplayItemBord()
        {
            WriteLine("==============================================");
            WriteLine("PRODUKTER");
            WriteLine("IKEA Skrivebord", 150, "Den er litt whack lowkey men den funker");
            WriteLine("==============================================");
        }

        public void DisplayItemGarderobeSkap()
        {
            WriteLine("==============================================");
            WriteLine("PRODUKTER");
            WriteLine("PAX skap", 1550, "Stor å fin garderobeskap med skyvedører");
            WriteLine("==============================================");

        }

        public void DisplayItemSofa()
        {
            WriteLine("==============================================");
            WriteLine("PRODUKTER");
            WriteLine("Scandinavian Sofa", 5600, "Behagelig 3 seters sofa laget med ekte skandinavisk kamel");
            WriteLine("==============================================");
        }
       


    }
}
