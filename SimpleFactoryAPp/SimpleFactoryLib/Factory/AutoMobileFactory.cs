using SimpleFactoryLib.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactoryLib.Factory
{
  public  class AutoMobileFactory
    {
        private static AutoMobileFactory automobileFactory;

        private AutoMobileFactory() { }
        public IAuto Make(AutoType auto)
        {
            if (auto == AutoType.TESLA) return new Tesla();
            else if (auto == AutoType.BMW) return new BMW();
            return new Auid();
        }
        public static AutoMobileFactory GetInstance()
        {
            if (automobileFactory == null) automobileFactory = new AutoMobileFactory();
            return automobileFactory;
        }

      
           
        }
    }

