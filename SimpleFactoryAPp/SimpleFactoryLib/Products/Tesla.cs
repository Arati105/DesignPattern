using SimpleFactoryLib.Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactoryLib.Products
{
    class Tesla:IAuto
    {
        public void Start()
        {
            Console.WriteLine("Tesla is starting");
        }

        public void Stop()
        {
            Console.WriteLine("Tesla is Stoped");
        }
    }
}
