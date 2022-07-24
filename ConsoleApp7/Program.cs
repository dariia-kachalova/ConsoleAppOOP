using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using drinkClassLibrary;

namespace drinkShopConsoleApp
{
    static class Program
    {
        static void Main(string[] args)
        {
            Store s = new Store();

            Console.WriteLine("Welcome to the caffee. Please make your order");

            int action = chooseAction();

            while (action != 0)
            {
                Console.WriteLine("You chose " + action);

                switch (action)
                {
                    //add item
                    case 1:
                        Console.WriteLine("You chose to add a new drink");
                        string drinkMake = "";
                        string drinkSize = "";
                        decimal drinkPrice = 0;

                        Console.WriteLine("What is the drink make? Coffee, tea, water, etc ");
                        drinkMake = Console.ReadLine();

                        Console.WriteLine("What is the drink size? Double, average? ");
                        drinkSize = Console.ReadLine();

                        Console.WriteLine("Please put the price you are ready to pay");
                        drinkPrice = int.Parse(Console.ReadLine());

                        Drink newDrink = new Drink(drinkMake, drinkSize, drinkPrice);
                        s.drinkList.Add(newDrink);

                        printInventory(s);
                        break;

                    //add to 
                    case 2:
                        Console.WriteLine("You chose to add a drink");
                        printInventory(s);
                        Console.WriteLine("Which item would you like to buy? (number)");
                        int drinkChosen = int.Parse(Console.ReadLine());

                        s.ShoppingList.Add(s.drinkList[drinkChosen]);

                        printShoppingCart(s);

                        break;

                    //checkout
                    case 3:
                        printShoppingCart(s);
                        Console.WriteLine("The total cost of your items is : " + s.Checkout());

                        break;

                    default:
                        break;
                }

                action = chooseAction();
            }


        }

        private static void printShoppingCart(Store s)
        {
            Console.WriteLine("drinks you have chosen to buy ");

            for (int i = 0; i < s.ShoppingList.Count; i++)
            {
                Console.WriteLine("drink # : " + i + " " + s.ShoppingList[i]);
            }
        }

        private static void printInventory(Store s)
        {
            for (int i = 0; i < s.drinkList.Count; i++)
            {
                Console.WriteLine("drink # : " + i + " " + s.drinkList[i]);
            }
        }

        static public int chooseAction()
        {
            int choice = 0;
            Console.WriteLine("Choose an action (0) to quit (1) to add a new drink (2) add drink to drinkt (3) checkout");

            choice = int.Parse(Console.ReadLine());
            return choice;
        }
    }
}
