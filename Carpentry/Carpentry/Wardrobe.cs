using System;
using System.Collections.Generic;
using System.Text;

namespace Carpentry
{
    class Wardrobe : IFurniture
    {
        public void AssembleFurniture(string wood, int price)
        {
            Console.WriteLine("------WARDROBE----");
            Console.WriteLine("The wardrobe will be plowed with the wood: " + wood + ", with a price of: " + price.ToString() +"Bs.");
        }
    }
}
