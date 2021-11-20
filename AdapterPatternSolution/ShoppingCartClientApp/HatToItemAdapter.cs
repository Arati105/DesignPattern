using FancyItemsLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCartClientApp
{
   public class HatToItemAdapter:Item
    {
        private Hat _hat;
        public HatToItemAdapter(Hat hat)
        {
            this._hat = hat;
        }

        public string ItemName()
        {
           
            throw new NotImplementedException();
        }

        /*   public string ItemName()
  {
      return _hat.GetShortName();
  }*/
        public double ItemPrice()
        {
            return _hat.GetPrice();
        }
       
    }
}
