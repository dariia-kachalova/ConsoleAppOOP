using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace drinkClassLibrary
{
    public class Store
    {
        public List<Drink> drinkList { get; set; }
        public List<Drink> ShoppingList { get; set; }

        public Store()
        {
            drinkList = new List<Drink>();
            ShoppingList = new List<Drink>();
        }

        public decimal Checkout()
        {
            decimal totalCost = 0;

            foreach (var c in drinkList)
            {
                totalCost += c.Price;
            }

            drinkList.Clear();

            return totalCost;
        }
    }
}