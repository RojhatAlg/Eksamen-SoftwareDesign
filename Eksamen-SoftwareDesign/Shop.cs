using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
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
            AskForCategory();
            DisplayOutro();
        }

        private void DisplayIntro()
        {
            WriteLine("==============================================");
            WriteLine("Vennligst velg en kategori mellom a-d");
            WriteLine("KATEGORI:");
            DisplayCategory();
            WriteLine("==============================================");
        }



        private void AskForCategory()
        {
            Produkt product = new Produkt();
           
            WriteLine("Vennligst velg et kategori mellom a-d");
            string kundeKategori = ReadLine();
            if(kundeKategori == "a")
            {
                product.DisplayItemStol();
            } if(kundeKategori == "b")
            {
                product.DisplayItemBord();
            } if(kundeKategori == "c")
            {
                product.DisplayItemGarderobeSkap();
            } if (kundeKategori == "d")
            {
                product.DisplayItemSofa();
            }


 

            //Trenger IF state som returnerer liste av produkter som er valgt av kategori fra bruker (a-d)

        }

        private void sellItem(string itemName, int cost, string beskrivelse)
        {
            WriteLine($"Navn: {itemName}\nPris: {cost} \nBeskrivelse: {beskrivelse}");

        }

        private void DisplayOrderTotal()
        {

        }

        private void DisplayCategory()
        {
            WriteLine("a: Stoler");
            WriteLine("b: Bord");
            WriteLine("c: Garderobe & Skap");
            WriteLine("d: Sofa");

        }
        
        private void DisplayOutro()
        {
            WriteLine("Thanks for shopping!");
            WriteLine("Press any key to exit...");
            ReadKey();
        }
        
    }
}
