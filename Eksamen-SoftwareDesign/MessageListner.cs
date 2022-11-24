using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NettButikk
{
     class MessageListner
    {
        public MessageListner()
        {
            Console.WriteLine("Hello, welcome to our Webshop!");
            Console.WriteLine("\nPress any button to enter the Webshop.");

            WebShopDataBase db = new();

            db.CreateDbAndTable();

            int firstProductId = db.InsertProduct("Elkjøp Sofa", "100");
            int secondProductId = db.InsertProduct("Ikea Gamingbord", "50");

            Product firstProductCreated = db.ReadProduct(firstProductId);
            Product secondProductCreated = db.ReadProduct(secondProductId);

            Console.WriteLine($"First product was:  '{firstProductCreated.ProductName}'" , $"First product was:  '{firstProductCreated.ProductPrice}'");
            Console.WriteLine($"Second product was: '{secondProductCreated.ProductPrice}'");
        }
    }
}
