using FactoryMethodLib.Product;

using FactoryMethodLib.Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodLib.Factory
{
    public class TeslaFactory : IAutoFactory
    {
        public IAuto Make()
        {
            return new Tesla();
        }
    }
}
