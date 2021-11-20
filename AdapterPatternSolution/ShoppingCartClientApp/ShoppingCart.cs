using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCartClientApp
{
    class ShoppingCart
    {
        public List<Item> items = new List<Item>();
        public double _totalPrice;

        public void Add(Item i)
        {
            items.Add(i);
        }
        public void Remove(Item i1)
        {
            items.Add(i1);
        }
       public double TotalPrice()
        {
            foreach(Item i2 in items)
            {
                _totalPrice += i2.ItemPrice();

            }
            return _totalPrice;
        }
       
    }

}
