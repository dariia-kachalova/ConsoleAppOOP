using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop
{
    public class Store
    {
        public List<Drink> DrinkList { get; set; }
        public List<Drink> ShoppingList { get; set; }

        public Store()
        {
            DrinkList = new List<Drink>();
            ShoppingList = new List<Drink>();
        }

        public decimal Checkout()
        {
            decimal totalCost = 0;

            foreach (var c in DrinkList)
            {
                totalCost += c.Price;
            }

            DrinkList.Clear();

            return totalCost;
        }
    }
}