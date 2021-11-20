using FactoryMethodLib.Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodLib.Product
{
    internal class BMW : IAuto
    {

        public void start()
        {
            Console.WriteLine("BMW is starting");
        }

        public void Stop()
        {
            Console.WriteLine("BMW is stop");
        }

        
    }
}
