using System;

namespace Carpentry
{
    class Program
    {
        static void Main(string[] args)
        {
            FurnitureFactory furnitureFactory = new ConcreteFurnitureFactory();

            IFurniture wardrobe = furnitureFactory.MakeFurniture("Wardrobe");
            wardrobe.AssembleFurniture("Oak", 1200);

            IFurniture desk = furnitureFactory.MakeFurniture("Desk");
            desk.AssembleFurniture("mahogany", 800);

            Console.ReadKey();
        }
    }
}
