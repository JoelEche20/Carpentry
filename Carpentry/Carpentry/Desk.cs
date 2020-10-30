using System;
using System.Collections.Generic;
using System.Text;

namespace Carpentry
{
    class Desk : IFurniture
    {
        public void AssembleFurniture(string wood, int price)
        {
            Console.WriteLine("---DESK---");
            Console.WriteLine("The desk will be plowed with the wood: " + wood + ", with a price of: " + price.ToString() + "Bs.");
        }
    }
}
