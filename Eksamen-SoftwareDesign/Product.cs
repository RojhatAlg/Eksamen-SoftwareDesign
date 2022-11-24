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
        internal string productName;
        internal string productPrice;
        internal string productDesc;

        public Product(string productName, string productPrice, string productDesc)
        {
            this.productName = productName;
            this.productPrice = productPrice;
            this.productDesc = productDesc; 
        }

        public string ProductName { 
            get { return productName; } 
        set { productName = value; }
        }

        public string ProductPrice
        {
            get { return productPrice; }
            set { productPrice = value; }
        }

        public String ProductDesc
        {
            get { return productDesc; }
            set { productDesc = value; }
        }

        public Product()
        {
        }
        

    }

    internal class DisplayProduct
    {
        public void DisplayItemStol()
        {

            WriteLine("==============================================");
            WriteLine("PRODUKTER");
            CreateProduct createProduct = new CreateProduct();
            createProduct.createItemStol();
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

    internal class CreateProduct
    {
        public void createItemStol()
        {

            WebShopDataBase db = new();

            db.CreateDbAndTable();

            int firstProductId = db.InsertProduct("Gaming stol", "2000", "Dette er en bra gaming stol. Svært behagelig for maaange lange gaming økter!");
            int secondProductId = db.InsertProduct("Luksus stol", "1100", "Vil du ha en stol? eller vil du ha noe mer enn en stol? " +
                "Har du alltid drømt om å sitte på en sky? Engst deg ikke! Kjøp denne luksus stolen, andre stoler skal føles ut som betong etter denne!");
            int thirdProductId = db.InsertProduct("Billig stol", "20", "Mye stol for pengene.");

            Product firstProductCreated = db.ReadProduct(firstProductId);
            Product secondProductCreated = db.ReadProduct(secondProductId);
            Product thirdProductCreated = db.ReadProduct(thirdProductId);

            Console.WriteLine($"a):\nNavn: '{firstProductCreated.ProductName}'\n" + $"Beskrivelse: '{firstProductCreated.ProductDesc}'\n" + $"Pris: '{firstProductCreated.ProductPrice}$'\n");
            Console.WriteLine($"b):\nNavn: '{secondProductCreated.ProductName}'\n" + $"Beskrivelse: '{secondProductCreated.ProductDesc}'\n" + $"Pris: '{secondProductCreated.ProductPrice}$'\n");
            Console.WriteLine($"c):\nNavn: '{thirdProductCreated.ProductName}'\n" + $"Beskrivelse: '{thirdProductCreated.ProductDesc}'\n" + $"Pris: '{thirdProductCreated.ProductPrice}$'\n");


        }

    }
}
