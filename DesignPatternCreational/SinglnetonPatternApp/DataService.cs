using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinglnetonPatternApp
{
  public class DataService
    {
        private static object locker = new object();
        static DataService _bucket;
        public DataService()
        {
            Console.WriteLine("DataService Created");

        }
        public void DoSomething()
        {
            Console.WriteLine("Work done by" + this.GetHashCode());
        }
        public static DataService GetInsurance()
        {
           if(_bucket==null)
            {
                lock (locker)
                {
                    if (_bucket == null)
                    {
                        _bucket = new DataService();
                    }
                }
            }
            return _bucket;
           // return new DataService();
        }
    }
}
