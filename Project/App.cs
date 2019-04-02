using System;
using SeanFoodStore.Project.Models;

namespace SeanFoodStore.Project
{
   class App
    {
         public Menu Menu { get; set; }
        public bool Ordering { get; set; }


        public void Run()
        {
            Console.Clear();
            while (Ordering)
            {
                if (Menu.Order.Count == 0)
                {
                    Console.WriteLine("Would you like to order a (D)rink or some (F)ood?");
                }
                else
                {
                    Console.WriteLine("Add a (D)rink, some (F)ood, or are you ready to (P)ay?");
                }

                string input = Console.ReadLine().ToLower();
                printOrder(input);
            }
        }

        void printOrder(string input)
         {
             switch (input)
             {
                 case "d":
                     Console.Clear();
                     Menu.printDrink();
                     orderedDrink();
                     break;
                 case "f" :
                     Console.Clear();
                     Menu.printFood();
                     orderedFood();
                     break;
                 case "p":
                     Console.Clear();
                     Menu.pay();
                     Console.WriteLine("I hope you enjoy your food if you don't blame your taste-buds this is the best food in town");
                     Ordering = false;
                     return;                  
             }   
         }

         void orderedDrink()
         {
             Console.WriteLine(@"
Please select a number: ");
             Int32.TryParse(Console.ReadLine(), out int choice);
             int length = Menu.Drink.Count + Menu.Shake.Count;
             if (choice > 0 && choice <= Menu.Drink.Count)
             {
                 Menu.Order.Add(Menu.Drink[choice - 1]);
                 Menu.printReceipt();
             }
             else if (choice > Menu.Drink.Count && choice <= length)
             {
                 Menu.Order.Add(Menu.Shake[choice - (Menu.Drink.Count + 1)]);
                 Menu.printReceipt();
             }
             else
             {
                 Console.WriteLine("You want for don't you? Then enter a correct selection.");
             }
         }
         
         void orderedFood()
         {
             Console.WriteLine(@"
Please select a number: ");
             Int32.TryParse(Console.ReadLine(), out int choice);
             int length = Menu.Entree.Count + Menu.Side.Count;
             if (choice > 0 && choice <= Menu.Entree.Count)
             {
                 Menu.Order.Add(Menu.Entree[choice - 1]);
                 Menu.printReceipt();
             }
             else if (choice > Menu.Entree.Count && choice <= length)
             {
                 Menu.Order.Add(Menu.Side[choice - (Menu.Entree.Count + 1)]);
                 Menu.printReceipt();
             }
             else
             {
                 Console.WriteLine("You want for don't you? Then enter a correct selection.");
             }
         }
        

        public App()
        {
            Menu = new Menu();
            Ordering = true;
        }
    }
}

