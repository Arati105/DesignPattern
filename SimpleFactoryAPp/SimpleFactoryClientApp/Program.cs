using SimpleFactoryLib;
using SimpleFactoryLib.Factory;
using System;
using AutoMobileFactory = SimpleFactoryLib.Factory.AutoMobileFactory;

namespace SimpleFactoryClientApp
{
    class Program
    {
      static void Main(string[] args)
        {
            var f1 = AutoMobileFactory.GetInstance();
            var automobile = f1.Make(AutoType.TESLA);
            automobile.Start();
            automobile.Stop();
            Console.WriteLine(f1.GetHashCode());

            var f2 = AutoMobileFactory.GetInstance();
            var automobile2 = f2.Make(AutoType.AUDI);
            automobile2.Start();
            automobile2.Stop();
            Console.WriteLine(f2.GetHashCode());
            Console.ReadKey();
           

        }
    }

    
    
}
