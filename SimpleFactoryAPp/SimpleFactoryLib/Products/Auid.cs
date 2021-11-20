using SimpleFactoryLib.Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactoryLib.Products
{
    class Auid : IAuto
    {
        public void Start()
        {
            Console.WriteLine("Auid is Starting");
        }

        public void Stop()
        {
            Console.WriteLine("Auid is Stoping");
        }
    }
}
