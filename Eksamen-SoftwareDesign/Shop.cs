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
            WriteLine("KATEGORI:");
            DisplayCategory();
            WriteLine("==============================================");
        }



        private void AskForCategory()
        {

            DisplayProduct product = new DisplayProduct();
            WriteLine("Vennligst velg et kategori mellom a-d");
            string kundeKategori = ReadLine();
            if(kundeKategori == "a")
            {
                product.DisplayItemStol();
                buyStol();
            } 
            if(kundeKategori == "b")
            {
                product.DisplayItemBord();
                buyTable();
            } 
            if(kundeKategori == "c")
            {
                product.DisplayItemGarderobeSkap();
                buySkap();
            } 
            if (kundeKategori == "d")
            {
                product.DisplayItemSofa();
                buySofa();
            }

        }

        private void buyStol()
        {
            Product product = new Product();
            String valgStol = ReadLine();

            if (valgStol == "a")
            {
                Money.totalCost += 2000;
                WriteLine("2000$ Has been added to the total cost. Total cost is now: " + Money.totalCost + "$");
                displayCheckout();
            }
            if (valgStol == "b")
            {
                Money.totalCost += 1100;
                WriteLine("1100$ Has been added to the total cost.");
                displayCheckout();
            }
        }

        private void buyTable()
        {
            Product product = new Product();
            String valgBord = ReadLine();
            
            if (valgBord == "a")
            {
                Money.totalCost += 150;
                WriteLine("150$ Has been added to the total cost. Total cost is now: " + Money.totalCost + "$");
                displayCheckout();
            }
            if (valgBord == "b")
            {
                Money.totalCost += 500;
                WriteLine("500$ Has been added to the total cost.");
                displayCheckout();
            }
        }

        private void buySkap()
        {
            Product product = new Product();
            String valgSkap = ReadLine();

            if (valgSkap == "a")
            {
                Money.totalCost += 1550;
                WriteLine("1550$ Has been added to the total cost. Total cost is now: " + Money.totalCost + "$");
                displayCheckout();
            }
            if (valgSkap == "b")
            {
                Money.totalCost += 750;
                WriteLine("750$ Has been added to the total cost.");
                displayCheckout();
            }
        }

        private void buySofa()
        {
            Product product = new Product();
            String valgSofa = ReadLine();

            if (valgSofa == "a")
            {
                Money.totalCost += 5600;
                WriteLine("5600$ Has been added to the total cost. Total cost is now: " + Money.totalCost + "$");
                displayCheckout();
            }
            if (valgSofa == "b")
            {
                Money.totalCost += 3500;
                WriteLine("3500$ Has been added to the total cost.");
                displayCheckout();
            }
        }

        private void displayCheckout()
        {
            WriteLine("Total cost is now: " + Money.totalCost + "$");
            WriteLine("Do you want to contine shopping? y/n");
            String continueYorN = ReadLine();
            if (continueYorN == "y"){
                run();

            } if (continueYorN == "n")
            {
                DisplayOutro();
            }
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
            WriteLine("Your totale came out to be: " + Money.totalCost);
            WriteLine("Thanks for shopping! :)");
            WriteLine("Press any key to exit...");
            ReadKey();
        }

    }
}
