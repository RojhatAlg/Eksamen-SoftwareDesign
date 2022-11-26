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
            Customer c = new Customer();
            Categories categories = new Categories();
            // Shop logic
            c.DisplayCustomers();
            DisplayIntro();
            categories.AskForCategory();
            DisplayOutro();
        }

        private void DisplayIntro()
        {
            WriteLine("==============================================");
            WriteLine("KATEGORI:");
            DisplayCategory();
            WriteLine("==============================================");
        }


        private void DisplayCategory()
        {
            WriteLine("a: Stoler");
            WriteLine("b: Bord");
            WriteLine("c: Garderobe & Skap");
            WriteLine("d: Sofa");

        }
        
        public void DisplayOutro()
        {
            WriteLine("Your totale came out to be: " + Money.totalCost);
            WriteLine("Thanks for shopping! :)");
            WriteLine("Press any key to exit...");
            ReadKey();
        }

    }

    public void AskForCategory()
           {
   
               DisplayProduct product = new DisplayProduct();
               WriteLine("Vennligst velg et kategori mellom a-d");
               string kundeKategori = ReadLine();
               Buy buy = new Buy();
               if (kundeKategori == "a")
               {
                   product.DisplayItemStol();
                   buy.buyStol();
               }
               if (kundeKategori == "b")
               {
                   product.DisplayItemBord();
                   buy.buyTable();
               }
               if (kundeKategori == "c")
               {
                   product.DisplayItemGarderobeSkap();
                   buy.buySkap();
               }
               if (kundeKategori == "d")
               {
                   product.DisplayItemSofa();
                   buy.buySofa();
               } internal class Categories
    {
       

        }
    }

    internal class Buy
    {

        ShoppingCart cart = new ShoppingCart();
        public void buyStol()
        {
            Product product = new Product();
            String valgStol = ReadLine();

            if (valgStol == "a")
            {
                Money.totalCost += 2000;
                WriteLine("2000$ Has been added to the total cost. Total cost is now: " + Money.totalCost + "$");
                cart.displayCheckout();
            }
            if (valgStol == "b")
            {
                Money.totalCost += 1100;
                WriteLine("1100$ Has been added to the total cost.");
                cart.displayCheckout();
            }
            if (valgStol == "c")
            {
                Money.totalCost += 20;
                WriteLine("20$ Has been added to the total cost.");
                cart.displayCheckout();
            }
        }

        public void buyTable()
        {
            Product product = new Product();
            String valgBord = ReadLine();

            if (valgBord == "a")
            {
                Money.totalCost += 1200;
                WriteLine("1200$ Has been added to the total cost. Total cost is now: " + Money.totalCost + "$");
                cart.displayCheckout();
            }
            if (valgBord == "b")
            {
                Money.totalCost += 380;
                WriteLine("380$ Has been added to the total cost.");
                cart.displayCheckout();
            }

            if (valgBord == "c")
            {
                Money.totalCost += 750;
                WriteLine("750$ Has been added to the total cost.");
                cart.displayCheckout();
            }
        }

        public void buySkap()
        {
            Product product = new Product();
            String valgSkap = ReadLine();

            if (valgSkap == "a")
            {
                Money.totalCost += 2230;
                WriteLine("2230$ Has been added to the total cost. Total cost is now: " + Money.totalCost + "$");
                cart.displayCheckout();
            }
            if (valgSkap == "b")
            {
                Money.totalCost += 630;
                WriteLine("630$ Has been added to the total cost.");
                cart.displayCheckout();
            }
        }

        public void buySofa()
        {
            Product product = new Product();
            String valgSofa = ReadLine();

            if (valgSofa == "a")
            {
                Money.totalCost += 3500;
                WriteLine("3500$ Has been added to the total cost. Total cost is now: " + Money.totalCost + "$");
                cart.displayCheckout();
            }
            if (valgSofa == "b")
            {
                Money.totalCost += 5000;
                WriteLine("5000$ Has been added to the total cost.");
                cart.displayCheckout();
            }
            if (valgSofa == "c")
            {
                Money.totalCost += 3350;
                WriteLine("3350$ Has been added to the total cost.");
                cart.displayCheckout();
            }
            if (valgSofa == "d")
            {
                Money.totalCost += 7850;
                WriteLine("7850$ Has been added to the total cost.");
                cart.displayCheckout();
            }
        }
    }

    internal class ShoppingCart
    {
        public void displayCheckout()
        {
            WriteLine("Total cost is now: " + Money.totalCost + "$");
            WriteLine("Do you want to contine shopping? y/n");
            String continueYorN = ReadLine();
            Shop shop = new Shop();
            if (continueYorN == "y")
            {
                shop.run();

            }
            if (continueYorN == "n")
            {
                shop.DisplayOutro();
            }
        }
    }
}
