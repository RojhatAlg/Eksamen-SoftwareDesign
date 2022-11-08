using System;

namespace NettButikk
{
    class Program
    {
        static void Main(string[] args)
        {

            MessageListner terminal = new();

            Console.ReadKey(true);

            Shop myShop = new Shop();
            myShop.run();
        }
    }
}