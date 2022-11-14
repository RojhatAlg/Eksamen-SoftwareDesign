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
            WriteLine("STOLER");
            WebShopDataBase db = new();

            //db.CreateDbAndTable();

            int firstProductId = db.InsertProduct("Elkjøp Sofa", "100");
            int secondProductId = db.InsertProduct("Ikea Gamingbord", "50");

            string firstProductCreated = db.ReadProductName(firstProductId);
            string secondProductCreated = db.ReadProductName(secondProductId);

            Console.WriteLine($"First product:  '{firstProductCreated}'");
            Console.WriteLine($"Second product: '{secondProductCreated}'");
            WriteLine("==============================================");
        }

    
        public void DisplayItemBord()
        {
            WriteLine("==============================================");
            WriteLine("PRODUKTER");
            sellItem("IKEA Skrivebord", 150, "Den er litt whack lowkey men den funker");
            WriteLine("==============================================");
        }

        public void DisplayItemGarderobeSkap()
        {
            WriteLine("==============================================");
            WriteLine("PRODUKTER");
            sellItem("PAX skap", 1550, "Stor å fin garderobeskap med skyvedører");
            WriteLine("==============================================");

        }

        public void DisplayItemSofa()
        {
            WriteLine("==============================================");
            WriteLine("PRODUKTER");
            sellItem("Scandinavian Sofa", 5600, "Behagelig 3 seters sofa laget med ekte skandinavisk kamel");
            WriteLine("==============================================");
        }

        private void sellItem(string itemName, int cost, string beskrivelse)
        {
            WriteLine($"Navn: {itemName}\nPris: {cost} \nBeskrivelse: {beskrivelse}");

        }



    }
}
