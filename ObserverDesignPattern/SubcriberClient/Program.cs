using PublisherLib;
using System;

namespace SubcriberClient
{
    class Program
    {
        static void Main(string[] args)
        {
            Account acc = new Account(101,"Arati",5000,"arati@gmail.com");
            acc.AddNotifier(new SmsNotifier());
            acc.AddNotifier(new EmailNotifier());
            acc.Deposit(1000);
            
        }
    }

   
}
