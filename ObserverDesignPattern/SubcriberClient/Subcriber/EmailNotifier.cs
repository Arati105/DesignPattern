using PublisherLib;
using PublisherLib.Publisher;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubcriberClient
{
    class EmailNotifier : INotifier
    {
        public void Notify(Account account)
        {
            Console.WriteLine("Email sent to account no:" + account.GetAccNo());
            Console.WriteLine ("Email Id:"+account.Email);
        }
    }
}
