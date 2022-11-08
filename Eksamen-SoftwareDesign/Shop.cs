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
            WriteLine("Vennligst velg en kategori mellom a-d");
            WriteLine("KATEGORI:");
            DisplayCategory();
            WriteLine("==============================================");
        }

        private void DisplayItems()
        {
            WriteLine("==============================================");
            WriteLine("PRODUKTER");
            sellItem("Asus gamingstol", 100, "Veldig Behagelig stol for gaming");
            WriteLine("==============================================");
        }

        private void AskForCategory()
        {
            WriteLine("Vennligst velg et kategori mellom a-d");
            string kundeKategori = ReadLine();

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
