namespace CoffeeShop
{
    class Program
    {

        delegate void Message();
        static void Main()
        {
            Message greet;
            greet = Hello;
            greet();

            static void Hello() => Console.WriteLine("Hello, welcome to Coffee Shop");

            List<string> drinks = new List<string>() { "Coffee", "Tea", "Water" };

            foreach (var drink in drinks)
            {
                Console.WriteLine("We have " + drink + " " +
                "press enter to continue");
            }

            Console.ReadLine();
            Store s = new Store();

            int Action = ChooseAction();

            while (Action != 0)
            {
                Console.WriteLine("You chose " + Action);

                switch (Action)
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
                        s.DrinkList.Add(newDrink);

                        PrintInventory(s);
                        break;

                    //add to 
                    case 2:
                        Console.WriteLine("You chose to add a drink");
                        PrintInventory(s);
                        Console.WriteLine("Which item would you like to buy? (number)");
                        int drinkChosen = int.Parse(Console.ReadLine());

                        s.ShoppingList.Add(s.DrinkList[drinkChosen]);

                        PrintShoppingCart(s);

                        break;

                    //checkout
                    case 3:
                        PrintShoppingCart(s);
                        string TeaColor = "green";


                        Console.WriteLine("The total cost of your items is : " + s.Checkout());
                        Console.WriteLine("You have a present - " + TeaColor + " tea");

                        break;

                    default:
                        break;
                }

                Action = ChooseAction();
            }


        }

        private static void PrintShoppingCart(Store s)
        {
            Console.WriteLine("drinks you have chosen to buy ");

            for (int i = 0; i < s.ShoppingList.Count; i++)
            {
                Console.WriteLine("drink # : " + i + " " + s.ShoppingList[i]);
            }
        }

        private static void PrintInventory(Store s)
        {
            for (int i = 0; i < s.DrinkList.Count; i++)
            {
                Console.WriteLine("drink # : " + i + " " + s.DrinkList[i]);
            }
        }

        static public int ChooseAction()
        {
            int choice = 0;
            Console.WriteLine("Choose an action (0) to quit (1) to add a new drink (2) add drink to drinkt (3) checkout");

            choice = int.Parse(Console.ReadLine());
            return choice;
        }
    }
}