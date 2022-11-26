using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace NettButikk
{
    class Shop
    {

        Money money = new Money();
        Customer c = new Customer();
        Categories categories = new Categories();

        public void startRun()
        {
            DisplayIntro();
            categories.AskForCategory();
            DisplayOutro();
        }
        public void run()
        {
            
            // Shop logic
            c.DisplayCustomers();
            DisplayIntro();
            categories.AskForCategory();
            DisplayOutro();
        }

        public void Exit()
        {
            DisplayExit();
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
            WriteLine("Your totale came out to be: " + Money.TotalCost +"$");
            WriteLine("Thanks for shopping! :)");
            WriteLine("Press any key to exit...");
            ReadKey();
        }

        public void DisplayExit()
        {

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

        Money money = new Money();

        ShoppingCart cart = new ShoppingCart();
        public void buyStol()
        {
            Product product = new Product();
            String valgStol = ReadLine();

            if (valgStol == "a")
            {
                Money.TotalCost += 2000;
                WriteLine("2000$ Has been added to the total cost. Total cost is now: " + Money.TotalCost + "$");
                cart.displayCheckout();
            }
            if (valgStol == "b")
            {
                Money.TotalCost += 1100;
                WriteLine("1100$ Has been added to the total cost.");
                cart.displayCheckout();
            }
            if (valgStol == "c")
            {
                Money.TotalCost += 20;
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
                Money.TotalCost += 1200;
                WriteLine("1200$ Has been added to the total cost. Total cost is now: " + Money.TotalCost + "$");
                cart.displayCheckout();
            }
            if (valgBord == "b")
            {
                Money.TotalCost += 380;
                WriteLine("380$ Has been added to the total cost.");
                cart.displayCheckout();
            }

            if (valgBord == "c")
            {
                Money.TotalCost += 750;
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
                Money.TotalCost += 2230;
                WriteLine("2230$ Has been added to the total cost. Total cost is now: " + Money.TotalCost + "$");
                cart.displayCheckout();
            }
            if (valgSkap == "b")
            {
                Money.TotalCost += 630;
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
                Money.TotalCost += 3500;
                WriteLine("3500$ Has been added to the total cost. Total cost is now: " + Money.TotalCost + "$");
                cart.displayCheckout();
            }
            if (valgSofa == "b")
            {
                Money.TotalCost += 5000;
                WriteLine("5000$ Has been added to the total cost.");
                cart.displayCheckout();
            }
            if (valgSofa == "c")
            {
                Money.TotalCost += 3350;
                WriteLine("3350$ Has been added to the total cost.");
                cart.displayCheckout();
            }
            if (valgSofa == "d")
            {
                Money.TotalCost += 7850;
                WriteLine("7850$ Has been added to the total cost.");
                cart.displayCheckout();
            }
        }
    }

    internal class ShoppingCart
    {
        Money money = new Money();
        
        public void displayCheckout()
        {


            int c = money.ReturnTotal();
            ForegroundColor = ConsoleColor.Green;
            WriteLine("Total cost is now: " + Money.TotalCost + "$");
            ForegroundColor = ConsoleColor.White;
            WriteLine("Do you want to contine shopping? y/n");
            int total = Money.TotalCost;
            int newBalance = Money.TotalBalance - Money.TotalCost;
            ForegroundColor = ConsoleColor.Green;
            WriteLine("You have " + newBalance + " Left in your account");
            ForegroundColor = ConsoleColor.White;
            String continueYorN = ReadLine();
            Shop shop = new Shop();
            
            if (continueYorN == "y" && newBalance > 0)
            {
                shop.startRun();

            }
            else
            {
                ForegroundColor = ConsoleColor.Red;
                WriteLine("Du har for lite penger, kom tilbake når du har mer...");
                ForegroundColor= ConsoleColor.White;
                shop.Exit();
                
            }
            if (continueYorN == "n" && newBalance >= 0)
            {
                shop.DisplayOutro();
            }
            else
            {
                ForegroundColor = ConsoleColor.Red;
                WriteLine("Du har for lite penger, kom tilbake når du har mer...");
                ForegroundColor = ConsoleColor.White;
                shop.Exit();
            }
        }
    }
}
