using System;
using System.Threading;

namespace SinglnetonPatternApp
{
    class Program
    {
        static void Main(string[] args)
        {
            /*  var sv1 = DataService.GetInsurance();
              var sv2 = DataService.GetInsurance();
            var sv1 = new DataService();
              var sv2 = new DataService();
              Console.WriteLine(sv1.GetHashCode());
              Console.WriteLine(sv2.GetHashCode());
              sv1.DoSomething();
              sv2.DoSomething();*/
            Thread t1 = new Thread(() =>
              {
                  DataService.GetInsurance().DoSomething();

              });
            Thread t2 = new Thread(() =>
            {
                DataService.GetInsurance().DoSomething();

            });
            t1.Start();
            t2.Start();
            Console.ReadLine();
        }
    }
}
