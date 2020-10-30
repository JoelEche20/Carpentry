using System;
using System.Collections.Generic;
using System.Text;

namespace Carpentry
{
    class ConcreteFurnitureFactory : FurnitureFactory
    {
        public override IFurniture MakeFurniture(string furniture)
        {
            switch (furniture)
            {
                case "Wardrobe":
                    return new Wardrobe();
                case "Desk":
                    return new Desk();
                default:
                    throw new Exception(string.Format("Furniture '{0}' cannot be created", furniture));
            }
        }
    }
}
