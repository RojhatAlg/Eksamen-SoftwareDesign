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

            int firstProductId = db.InsertProduct("Elkjøp Sofa");
            int secondProductId = db.InsertProduct("Ikea Gamingbord");

            string firstProductCreated = db.ReadProductName(firstProductId);
            string secondProductCreated = db.ReadProductName(secondProductId);

            Console.WriteLine($"First product was:  '{firstProductCreated}'");
            Console.WriteLine($"Second product was: '{secondProductCreated}'");
        }
    }
}
