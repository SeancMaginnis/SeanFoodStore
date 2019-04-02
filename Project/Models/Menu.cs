using System;
using System.Collections.Generic;


namespace SeanFoodStore.Project.Models
{
     class Menu 
    {
        public List<Entree> Entree { get; set; }
        public List<Drink> Drink { get; set; }
        public List<Side> Side { get; set; }

        public List<Shake> Shake { get; set; }

        public List<ItemBase> Order { get; set; }

        

        public void printFood()
        {
            
            Console.WriteLine("Entrees: ");
            for (int i = 0; i < Entree.Count; i++)
            {
                Entree e = Entree[i];
                Console.WriteLine($"{i + 1}. {e.Name} ${e.Price} Calories:{e.Calories}");
                Console.WriteLine($@"{
                    e.Description}");
            }
            Console.WriteLine(Environment.NewLine);
            Console.WriteLine("Sides: ");
            for (int i = 0; i < Side.Count; i++)
            {
                Side s = Side[i];
                Console.WriteLine($"{Entree.Count + i + 1}. {s.Name} ${s.Price} Calories:{s.Calories}");
                Console.WriteLine($@"{
        s.Description}");
            }
        }

        public void printDrink()
        {
            Console.WriteLine("Drinks:");
            for (int i = 0; i < Drink.Count; i++)
            {
                Drink d = Drink[i];
                Console.WriteLine($"{i + 1}. {d.Name} ${d.Price} Calories:{d.Calories}");
                Console.WriteLine($@"{
        d.Description}");
            }
            Console.WriteLine(Environment.NewLine);
            Console.WriteLine("Shakes:");
            for (int i = 0; i < Shake.Count; i++)
            {
                Shake s = Shake[i];
                Console.WriteLine($"{Drink.Count + i + 1}. {s.Name} ${s.Price} Calories:{s.Calories}");
                Console.WriteLine($@"{
        s.Description}");
            }
        }

        public void printReceipt()
        {
            Console.Clear();
            Console.WriteLine("Please confirm your order:");
            for (int i = 0; i < Order.Count; i++)
            {
                ItemBase o = Order[i];
                Console.WriteLine($"{i + 1}. {o.Name} ${o.Price} Calories:{o.Calories}");
                
            }
        }

        public void pay()
        {
            float total = 0;
            foreach (ItemBase t in Order)
            {
                total += t.Price;
            }

            const float tax = 1.08f;
            total *= tax;
            Console.WriteLine($"Total: ${total}");
        }

        public Menu()
        {




            Entree = new List<Entree>()
            {
                new Entree("Plain Burger", "Nothing on it other than meat and bun please ask to add something to it.",
                    3.25f, 248),
                new Entree("Cheese Burger",
                "This Cheese Burger ROCKS! Our cook Bob adds lettuce, tomato, onion, pickles, mustard to make a bomb digidy burger you won't ever forget!",
                4.50f, 465),
                new Entree("Finger Steaks",
                "Battered in our special beer batter and deep fried to golden brown perfection!", 5.65f, 650)
            };

            Side = new List<Side>()
            {
                new Side("French Fries",
                    "Everyone knows what these are, if you don't then TRY THEM!!", 2.35f, 345),
                new Side("Tator Tots", "Yummy delicious golden tots", 2.45f, 360),
                new Side("Fried Okra", "Okra battered and deep fried to perfection", 4.30f, 245),

            };

            Drink = new List<Drink>()
            {


                new Drink("Dr. Pepper", "No one knows what's in it, but it sure is yummy!", 1.5f, 145),
                new Drink("Mtn Dew", "Do the Dew don't worry it won't rot your teeth out >.>", 1.5f, 160),
                new Drink("Water", "It's water if you don't know what it is go away!", 0, 0),
                new Drink("Lemonade", "Well it's sugar and lemons which makes a yummy drink.", 1.5f, 150),
            };

            Shake = new List<Shake>()
            {
                new Shake("Strawberry", "Harvest ripe strawberries blended with the best vanilla ice-cream you've ever had!", 2.5f, 680),
                new Shake("Banana", "It's a banana shake", 2.5f, 700),
                new Shake("Chocolate", "Hey it's a chocolate shake crazy right!", 2.5f, 890),
                new Shake("Vanilla", "If you want this I understand it's yummy, but it sure is boring", 2.5f, 700),

            };
            
            Order = new List<ItemBase>() { };

        }
        
    }
}