using System;
using System.Collections.Generic;
using System.Text;

namespace Carpentry
{
    public abstract class FurnitureFactory
    {
        public abstract IFurniture MakeFurniture(string furniture);
    }
}
