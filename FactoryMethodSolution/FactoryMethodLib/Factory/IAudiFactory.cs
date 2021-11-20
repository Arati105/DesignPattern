using FactoryMethodLib.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodLib.Factory
{
  public class IAudiFactory:IAutoFactory
    {
       public IAuto Make()
        {
            return new Audi();
        }
    }
}
