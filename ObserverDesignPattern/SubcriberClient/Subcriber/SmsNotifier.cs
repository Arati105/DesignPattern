
using PublisherLib;
using PublisherLib.Publisher;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubcriberClient
{
    class SmsNotifier : INotifier
    {
        public void Notify(Account account)
        {
            Console.WriteLine("SMS send to account number:"+account.GetAccNo());
        }

       
    }


}
