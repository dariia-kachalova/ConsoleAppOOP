using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop
{
    public class Drink
    {
        public string Make { get; set; }
        public string Size { get; set; }
        public decimal Price { get; set; }

        public Drink()
        {
            this.Make = "nothing yet";
            this.Size = "nothing yet";
            this.Price = 0.00M;
        }

        public Drink(string a, string b, decimal c)
        {
            Make = a;
            Size = b;
            Price = c;
        }

        override public string ToString()
        {
            return "Make: " + Make + " Size: " + Size + " Price: $ " + Price;

        }

    }

    public class Tea : Drink
    {
        public string TeaColor { get; set; }

        public Tea()
        {
            this.TeaColor = "green";
        }

            

    }
}