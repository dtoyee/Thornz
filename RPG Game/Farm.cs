using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace RPG_Game
{
    class Farm
    {

        private Menu menu;
        private Player player;
        private Shop shop;
        private Fishing fishing;
        private WoodCut woodcut;
        private Mine mine;
        private Monster monster;
        private Quests quests;
        private Save save;
        private Load load;
        private Farm farm;

        public void farmMenu(Player player, Menu menu, Shop shop, Fishing fishing, WoodCut woodcut, Mine mine, Monster monster, Quests quests, Save save, Load load, Farm farm)
        {

            this.player = player;
            this.menu = menu;
            this.shop = shop;
            this.fishing = fishing;
            this.woodcut = woodcut;
            this.mine = mine;
            this.monster = monster;
            this.quests = quests;
            this.save = save;
            this.load = load;
            this.farm = farm;

            Console.WriteLine("");
            Console.WriteLine("Welcome to Thornz farm! The best farm in Thornz City!");
            Console.WriteLine("We have a wide variety of animals here at Thornz farm.");
            Console.WriteLine("");
            Console.WriteLine("What could we help you with?");
            Console.WriteLine("");
            Console.WriteLine("1. I need to look at the chickens.");
            Console.WriteLine("2. I need to look at the cows.");
            Console.WriteLine("3. I need some corn.");
            Console.WriteLine("4. Exit");
            Console.WriteLine("");
            string choice = Console.ReadLine();

            if(choice.Equals("1"))
            {
                Console.WriteLine("");
                Console.WriteLine("Ahhh, yes! The chickens!");
                Console.WriteLine("They're just round the corner.");

                chicken(player);
            }
            else if(choice.Equals("2")){
                Console.WriteLine("");
                Console.WriteLine("Ahhh, yes! The cows!");
                Console.WriteLine("They're just straight ahead.");

                cow(player);
            }
            else if (choice.Equals("3"))
            {
                Console.WriteLine("");
                Console.WriteLine("Please only take one piece of corn at a time.");
                wheat(player);
            }
            else if(choice.Equals("4"))
            {
                menu.start(menu, shop, player, fishing, woodcut, mine, monster, quests, save, load, farm);
            }
            else
            {
                Console.WriteLine("Invalid choice!");
                farmMenu(player, menu, shop, fishing, woodcut, mine, monster, quests, save, load, farm);
            }
        }

        public void chicken(Player player)
        {

            this.player = player;

            Random rand = new Random();
            int x = rand.Next(10) + 1;
            string[] drops = new string[] { "Feather", "Egg" };
            string drop = drops[rand.Next(drops.Length)];

            Console.WriteLine("");
            Console.WriteLine("You walk over to the chicken coop and see a lot of chickens.");
            Console.WriteLine("You can try kill a chicken without the farmer noticing.");
            Console.WriteLine("");
            Console.WriteLine("Do you want to try kill a chicken? Yes/No");
            string choice = Console.ReadLine();

            if(choice.Equals("Yes") || choice.Equals("yes"))
            {
                if (x == 7)
                {
                    Console.WriteLine("");
                    Console.WriteLine("HEY! What do you think you're doing!");
                    Console.WriteLine("You're NOT meant to kill the chickens!");
                    Console.WriteLine("Get off MY FARM!");
                    Console.WriteLine("");
                    Console.WriteLine("You run off the farm as fast as you can.");
                    menu.start(menu, shop, player, fishing, woodcut, mine, monster, quests, save, load, farm);
                }
                else
                {

                    string name = "Chicken";
                    int monsterHealth = 5;
                    int level = 1;
                    int strength = 3;

                    while (player.health >= 1)
                    {

                        int chickenDamange = rand.Next(2) + 1 * strength / player.defence;
                        int playerDamage = player.playerStrength * rand.Next(3) / 2;

                        Console.WriteLine("The chicken is level " + level + ". Do you wish to fight him? Yes/No");
                        string choice2 = Console.ReadLine();

                        if (choice2.Equals("Yes") || choice2.Equals("yes"))
                        {

                            Console.WriteLine("");
                            Console.WriteLine("The " + name + " hits you for " + chickenDamange);
                            Console.WriteLine("");
                            player.health -= chickenDamange;
                            Console.WriteLine("Your health: " + player.health);
                            Console.WriteLine("");
                            Console.WriteLine("You hit the " + name + " for " + playerDamage);
                            Console.WriteLine("");
                            monsterHealth -= playerDamage;
                            Console.WriteLine(name + "s  health: " + monsterHealth);
                            Console.WriteLine("");

                            if (player.health <= 0)
                            {
                                Console.WriteLine("You died!");
                                Console.WriteLine("Press any key to continue.");
                                Console.WriteLine("");
                                Console.ReadLine();
                            }
                            else if (monsterHealth <= 0)
                            {
                                Console.WriteLine("You killed the " + name + "!");
                                Console.WriteLine("You picked up a " + drop);
                                Console.WriteLine("");
                                player.xp += 5;
                                player.inventory.Add(drop);
                                player.monsterKills++;
                                menu.start(menu, shop, player, fishing, woodcut, mine, monster, quests, save, load, farm);
                            }
                        }
                    }
                }
            }
            else if (choice.Equals("No") || choice.Equals("no"))
            {
                Console.WriteLine("");
                Console.WriteLine("You walk away from the chicken coop.");
                farmMenu(player, menu, shop, fishing, woodcut, mine, monster, quests, save, load, farm);
            }
            else
            {
                Console.WriteLine("Invalid choice!");
                farmMenu(player, menu, shop, fishing, woodcut, mine, monster, quests, save, load, farm);
            }
        }

        public void cow(Player player)
        {

            this.player = player;

            Console.WriteLine("");
            Console.WriteLine("You walk over to the group of cows.");
            Console.WriteLine("");
            Console.WriteLine("What would you like to do?");
            Console.WriteLine("1. Milk a cow");
            Console.WriteLine("2. Exit");
            string choice = Console.ReadLine();

            if(choice.Equals("1"))
            {
                if (player.inventory.Contains("Bucket"))
                {
                    Console.WriteLine("");
                    Console.WriteLine("You slowly walk towards the cow in the corner.");
                    Console.WriteLine("");
                    Console.WriteLine("You milk the cow and manage to get a bucket of milk.");
                    Console.WriteLine("");

                    player.inventory.Remove("Bucket");
                    player.inventory.Add("Bucket of milk");
                    menu.start(menu, shop, player, fishing, woodcut, mine, monster, quests, save, load, farm);
                }
                else
                {
                    Console.WriteLine("");
                    Console.WriteLine("You need a bucket to milk a cow.");
                    Console.WriteLine("");
                    farmMenu(player, menu, shop, fishing, woodcut, mine, monster, quests, save, load, farm);
                }
            }
            else if (choice.Equals("2"))
            {
                farmMenu(player, menu, shop, fishing, woodcut, mine, monster, quests, save, load, farm);
            }
            else
            {
                Console.WriteLine("Invalid choice!");
                farmMenu(player, menu, shop, fishing, woodcut, mine, monster, quests, save, load, farm);
            }
        }

        public void wheat(Player player)
        {

            this.player = player;

            Console.WriteLine("");
            Console.WriteLine("You walk over to the wheat field and pick one wheat.");
            Console.WriteLine("");
            Console.WriteLine("What do you want to do?");
            Console.WriteLine("");
            Console.WriteLine("1. Turn it into flour.");
            Console.WriteLine("2. Exit");
            string choice = Console.ReadLine();

            if(choice.Equals("1"))
            {
                Console.WriteLine("");
                Console.WriteLine("You walk over to the mill.");
                mill(player);
            }
            else if (choice.Equals("2"))
            {
                Console.WriteLine("");
                Console.WriteLine("You leave the farm");
                menu.start(menu, shop, player, fishing, woodcut, mine, monster, quests, save, load, farm);
            }
            else
            {
                Console.WriteLine("Invalid choice!");
                farmMenu(player, menu, shop, fishing, woodcut, mine, monster, quests, save, load, farm);
            }
        }

        public void mill(Player player)
        {

            this.player = player;

            Random rand = new Random();
            int b = rand.Next(20) + 1;

            if (player.inventory.Contains("Pot"))
            {
                Console.WriteLine("");
                Console.WriteLine("You place the wheat in the grinder.");
                Console.WriteLine("Please wait 10 seconds for it to finish.");
                Console.WriteLine("");

                if (b == 14)
                {
                    Console.WriteLine("");
                    Console.WriteLine("The piece of corn jams the machine.");
                    Console.WriteLine("The machine starts to smoke.");
                    Console.WriteLine("You run away from the machine and leave the farm...");
                    Console.WriteLine("");
                    menu.start(menu, shop, player, fishing, woodcut, mine, monster, quests, save, load, farm);
                }
                else
                {
                    Thread.Sleep(10000);
                    Console.WriteLine("");
                    Console.WriteLine("The machine has finished.");
                    Console.WriteLine("You now have a pot of flour.");

                    player.inventory.Remove("Pot");
                    player.inventory.Add("Pot of flour");
                    menu.start(menu, shop, player, fishing, woodcut, mine, monster, quests, save, load, farm);
                }
            }
            else
            {
                Console.WriteLine("");
                Console.WriteLine("You need a pot to get the flour.");
                menu.start(menu, shop, player, fishing, woodcut, mine, monster, quests, save, load, farm);
            }
        }
    }
}
