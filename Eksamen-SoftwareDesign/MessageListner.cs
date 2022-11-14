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

            string firstProductCreated = db.ReadProductName(firstProductId);
            string secondProductCreated = db.ReadProductName(secondProductId);

            Console.WriteLine($"First product was:  '{firstProductCreated}'");
            Console.WriteLine($"Second product was: '{secondProductCreated}'");
        }
    }
}
