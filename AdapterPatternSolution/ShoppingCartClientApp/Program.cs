
using FancyItemsLib;
using System;

namespace ShoppingCartClientApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var shoppingCart = new ShoppingCart();
            shoppingCart.Add(new HatToItemAdapter(new Hat("Hat", "Golden ribbon premium hat", 500)));
            PrintDetails(shoppingCart);

        }
        private static void PrintDetails(ShoppingCart shoppingCart)
        {
            Console.WriteLine("Item Details:");
            foreach(Item item in shoppingCart.items)
            {
                Console.WriteLine("Item Name:" + item.ItemName());
                Console.WriteLine("Item Price:" + item.ItemPrice());
            }
        }

    }
    
}
