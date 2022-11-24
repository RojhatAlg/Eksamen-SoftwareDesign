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

            int firstProductId = db.InsertProduct("Elkjøp Sofa", "100", "Stor sofa for 3 personer", "2", "1", "5");
            int secondProductId = db.InsertProduct("Ikea Gamingbord", "50", "Bra gaming bord", "1", "43", "123123");

            Product firstProductCreated = db.ReadProduct(firstProductId);
            Product secondProductCreated = db.ReadProduct(secondProductId);

            Console.WriteLine($"First product was:  '{firstProductCreated.ProductName}'" + $" '{firstProductCreated.ProductPrice}' kroner " + $" Beskrivelse: {firstProductCreated.ProductDesc}");
            Console.WriteLine($"Second product was: '{secondProductCreated.ProductName}'"+ $" '{secondProductCreated.ProductPrice}' kroner " + $" Beskrivelse: {secondProductCreated.ProductDesc}");
        }
    }
}
