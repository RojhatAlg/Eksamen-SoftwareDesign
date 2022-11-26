using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
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
        internal string productHeight;
        internal string productLenght;
        internal string productWidth;

        public Product(string productName, string productPrice, string productDesc, string productHeight, string productLenght, string productWidth)
        {
            this.productName = productName;
            this.productPrice = productPrice;
            this.productDesc = productDesc; 
            this.productHeight = productHeight;
            this.productLenght = productLenght;
            this.productWidth = productWidth;
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

        public string ProductDesc
        {
            get { return productDesc; }
            set { productDesc = value; }
        }

        public string ProductHeight
        {
            get { return productHeight; }
            set { productHeight = value; }
        }

        public string ProductLenght
        {
            get { return productLenght; }
            set { productLenght = value; }
        }

        public string ProductWidth
        {
            get { return productWidth; }
            set { productWidth = value; }
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
            CreateProduct createProduct = new CreateProduct();
            createProduct.createItemBord();
            WriteLine("==============================================");
        }

        public void DisplayItemGarderobeSkap()
        {
            WriteLine("==============================================");
            WriteLine("PRODUKTER");
            CreateProduct createProduct = new CreateProduct();
            createProduct.createItemGarderobeSkap();
            WriteLine("==============================================");

        }

        public void DisplayItemSofa()
        {
            WriteLine("==============================================");
            WriteLine("PRODUKTER");
            CreateProduct createProduct = new CreateProduct();
            createProduct.createItemSofa();
            WriteLine("==============================================");
        }
    }

    internal class CreateProduct
    {
        public void createItemStol()
        {

            WebShopDataBase db = new();

            db.CreateDbAndTable();

            //Create the Items

            int firstProductId = db.InsertProduct("Gaming stol", "2000", "Dette er en bra gaming stol. Svært behagelig for maaange lange gaming økter!", "100", "50", "60");
            int secondProductId = db.InsertProduct("Luksus stol", "1100", "Vil du ha en stol? eller vil du ha noe mer enn en stol? " +
                "Har du alltid drømt om å sitte på en sky? Engst deg ikke! Kjøp denne luksus stolen, andre stoler skal føles ut som betong etter denne!", "75", "100", "45");
            int thirdProductId = db.InsertProduct("Billig stol", "20", "Mye stol for pengene.", "50", "60", "50");

            Product firstProductCreated = db.ReadProduct(firstProductId);
            Product secondProductCreated = db.ReadProduct(secondProductId);
            Product thirdProductCreated = db.ReadProduct(thirdProductId);

            //Display the Items
            //Stol 1:

            Console.WriteLine($"a):\nNavn: '{firstProductCreated.ProductName}'\n" + $"Beskrivelse: '{firstProductCreated.ProductDesc}'\n" 
                + $"Høyde: '{firstProductCreated.ProductHeight}cm'\n"
                + $"Lengde: '{firstProductCreated.ProductLenght}cm'\n"
                + $"Bredde: '{firstProductCreated.ProductWidth}cm'\n"
                + $"Pris: '{firstProductCreated.ProductPrice}$'\n");

            //Stol 2:

            Console.WriteLine($"b):\nNavn: '{secondProductCreated.ProductName}'\n" + $"Beskrivelse: '{secondProductCreated.ProductDesc}'\n"
                + $"Høyde: '{secondProductCreated.ProductHeight}cm'\n"
                + $"Lengde: '{secondProductCreated.ProductLenght}cm'\n"
                + $"Bredde: '{secondProductCreated.ProductWidth}cm'\n"
                + $"Pris: '{secondProductCreated.ProductPrice}$'\n");

            //Stol 3:

            Console.WriteLine($"c):\nNavn: '{thirdProductCreated.ProductName}'\n" + $"Beskrivelse: '{thirdProductCreated.ProductDesc}'\n"
                + $"Høyde: '{thirdProductCreated.ProductHeight}cm'\n"
                + $"Lengde: '{thirdProductCreated.ProductLenght}cm'\n"
                + $"Bredde: '{thirdProductCreated.ProductWidth}cm'\n"
                + $"Pris: '{thirdProductCreated.ProductPrice}$'\n");



        }

        public void createItemBord()
        {

            WebShopDataBase db = new();

            db.CreateDbAndTable();

            //Create the Items

            int firstProductId = db.InsertProduct("Gamingbord", "1200", "Dette er et bra gaming bord. Passer perfekt med kombinasjon til gaming stol", "75", "180", "80");
            int secondProductId = db.InsertProduct("Skrivebord", "380", "Skrivebord fra Ikea. Perfekt for skolearebeid", "75", "100", "45");
            int thirdProductId = db.InsertProduct("Spisebord", "750", "Spiser din familie middag på bakken? Er du lei av å spise middag på bakken? Trenger din familie et spisebord?" +
                " Engst ikke mer! Kjøp vår billige spisebord! Bordet har plass til hele familien! Til å med bikkja!", "75", "250", "120");

            Product firstProductCreated = db.ReadProduct(firstProductId);
            Product secondProductCreated = db.ReadProduct(secondProductId);
            Product thirdProductCreated = db.ReadProduct(thirdProductId);

            //Display the Items
            //Stol 1:

            Console.WriteLine($"a):\nNavn: '{firstProductCreated.ProductName}'\n" + $"Beskrivelse: '{firstProductCreated.ProductDesc}'\n"
                + $"Høyde: '{firstProductCreated.ProductHeight}cm'\n"
                + $"Lengde: '{firstProductCreated.ProductLenght}cm'\n"
                + $"Bredde: '{firstProductCreated.ProductWidth}cm'\n"
                + $"Pris: '{firstProductCreated.ProductPrice}$'\n");

            //Stol 2:

            Console.WriteLine($"b):\nNavn: '{secondProductCreated.ProductName}'\n" + $"Beskrivelse: '{secondProductCreated.ProductDesc}'\n"
                + $"Høyde: '{secondProductCreated.ProductHeight}cm'\n"
                + $"Lengde: '{secondProductCreated.ProductLenght}cm'\n"
                + $"Bredde: '{secondProductCreated.ProductWidth}cm'\n"
                + $"Pris: '{secondProductCreated.ProductPrice}$'\n");

            //Stol 3:

            Console.WriteLine($"c):\nNavn: '{thirdProductCreated.ProductName}'\n" + $"Beskrivelse: '{thirdProductCreated.ProductDesc}'\n"
                + $"Høyde: '{thirdProductCreated.ProductHeight}cm'\n"
                + $"Lengde: '{thirdProductCreated.ProductLenght}cm'\n"
                + $"Bredde: '{thirdProductCreated.ProductWidth}cm'\n"
                + $"Pris: '{thirdProductCreated.ProductPrice}$'\n");



        }

        public void createItemGarderobeSkap()
        {

            WebShopDataBase db = new();

            db.CreateDbAndTable();

            //Create the Items

            int firstProductId = db.InsertProduct("Garderobe", "2230", "Stort garderobe til alle dine klær.", "190", "140", "65");
            int secondProductId = db.InsertProduct("Skap", "630", "Langskap for diverse utstyr", "220", "80", "60");

            Product firstProductCreated = db.ReadProduct(firstProductId);
            Product secondProductCreated = db.ReadProduct(secondProductId);

            //Display the Items
            //Garderobe 1:

            Console.WriteLine($"a):\nNavn: '{firstProductCreated.ProductName}'\n" + $"Beskrivelse: '{firstProductCreated.ProductDesc}'\n"
                + $"Høyde: '{firstProductCreated.ProductHeight}cm'\n"
                + $"Lengde: '{firstProductCreated.ProductLenght}cm'\n"
                + $"Bredde: '{firstProductCreated.ProductWidth}cm'\n"
                + $"Pris: '{firstProductCreated.ProductPrice}$'\n");

            //Skap 2:

            Console.WriteLine($"b):\nNavn: '{secondProductCreated.ProductName}'\n" + $"Beskrivelse: '{secondProductCreated.ProductDesc}'\n"
                + $"Høyde: '{secondProductCreated.ProductHeight}cm'\n"
                + $"Lengde: '{secondProductCreated.ProductLenght}cm'\n"
                + $"Bredde: '{secondProductCreated.ProductWidth}cm'\n"
                + $"Pris: '{secondProductCreated.ProductPrice}$'\n");



        }

        public void createItemSofa()
        {

            WebShopDataBase db = new();

            db.CreateDbAndTable();

            //Create the Items

            int firstProductId = db.InsertProduct("Gaming Sofa", "3500", "Gaming + Sofa i samme setning? Trenger vi å si mer?", "45", "75", "90");
            int secondProductId = db.InsertProduct("3-seters Sofa", "5000", "Fin 3 seters sofa, perfekt for stor stue. Laget av ekte skinn.", "50", "200", "100");
            int thirdProductId = db.InsertProduct("2-seters Sofa", "3350", "Fin 2-seters sofa, perfekt for litt mindre stuer.", "48", "150", "95");
            int fourthProductId = db.InsertProduct("5-seters Sofa", "7850", "Har du hørt 'Større = Bedre'?, vel i dette tilfelle stemmer det 100%!", "50", "350", "110");

            Product firstProductCreated = db.ReadProduct(firstProductId);
            Product secondProductCreated = db.ReadProduct(secondProductId);
            Product thirdProductCreated = db.ReadProduct(thirdProductId);
            Product fourthProductCreated = db.ReadProduct(fourthProductId);

            //Display the Items
            //Stol 1:

            Console.WriteLine($"a):\nNavn: '{firstProductCreated.ProductName}'\n" + $"Beskrivelse: '{firstProductCreated.ProductDesc}'\n"
                + $"Høyde: '{firstProductCreated.ProductHeight}cm'\n"
                + $"Lengde: '{firstProductCreated.ProductLenght}cm'\n"
                + $"Bredde: '{firstProductCreated.ProductWidth}cm'\n"
                + $"Pris: '{firstProductCreated.ProductPrice}$'\n");

            //Stol 2:

            Console.WriteLine($"b):\nNavn: '{secondProductCreated.ProductName}'\n" + $"Beskrivelse: '{secondProductCreated.ProductDesc}'\n"
                + $"Høyde: '{secondProductCreated.ProductHeight}cm'\n"
                + $"Lengde: '{secondProductCreated.ProductLenght}cm'\n"
                + $"Bredde: '{secondProductCreated.ProductWidth}cm'\n"
                + $"Pris: '{secondProductCreated.ProductPrice}$'\n");

            //Stol 3:

            Console.WriteLine($"c):\nNavn: '{thirdProductCreated.ProductName}'\n" + $"Beskrivelse: '{thirdProductCreated.ProductDesc}'\n"
                + $"Høyde: '{thirdProductCreated.ProductHeight}cm'\n"
                + $"Lengde: '{thirdProductCreated.ProductLenght}cm'\n"
                + $"Bredde: '{thirdProductCreated.ProductWidth}cm'\n"
                + $"Pris: '{thirdProductCreated.ProductPrice}$'\n");

            //Stol 4:

            Console.WriteLine($"c):\nNavn: '{fourthProductCreated.ProductName}'\n" + $"Beskrivelse: '{fourthProductCreated.ProductDesc}'\n"
                + $"Høyde: '{fourthProductCreated.ProductHeight}cm'\n"
                + $"Lengde: '{fourthProductCreated.ProductLenght}cm'\n"
                + $"Bredde: '{fourthProductCreated.ProductWidth}cm'\n"
                + $"Pris: '{fourthProductCreated.ProductPrice}$'\n");



        }



    }
}
