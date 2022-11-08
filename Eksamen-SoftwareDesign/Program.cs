using Eksamen_SoftwareDesign;
using NettButikk;
using System;

namespace Eksamen_SoftwareDesign
{
    class Porgram
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