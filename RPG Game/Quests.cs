using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RPG_Game
{
    class Quests
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

        public void questMenu(Player player, Menu menu, Shop shop, Fishing fishing, WoodCut woodcut, Mine mine, Monster monster, Quests quests, Save save, Load load, Farm farm)
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
            Console.WriteLine("---Quests---");
            Console.WriteLine("");
            Console.WriteLine("1. The key hunt - Easy");
            Console.WriteLine("2. Goblin hunter - Easy");
            Console.WriteLine("3. Bread Maker - Medium");
            Console.WriteLine("0. Exit");
            Console.WriteLine("");
            Console.WriteLine("Type the number of the quest you would like to do.");
            string choice = Console.ReadLine();

            if (choice.Equals("1"))
            {
                keyHunt();
            }
            else if (choice.Equals("2"))
            {
                goblinHunter();
            }
            else if (choice.Equals("3"))
            {
                breadMaker(player);
            }
            else if (choice.Equals("0"))
            {
                menu.start(menu, shop, player, fishing, woodcut, mine, monster, quests, save, load, farm);
            }
            else
            {
                Console.WriteLine("Invalid option!");
                questMenu(player, menu, shop, fishing, woodcut, mine, monster, quests, save, load, farm);
            }
        }


        public void keyHunt()
        {

            int reward = 50;

            if (!player.inventory.Contains("Key"))
            {
                Console.WriteLine("");
                Console.WriteLine("Welcome, traveller!");
                Console.WriteLine("I seem to have lost my key for my.. err.. shed.");
                Console.WriteLine("I remember I last had it in the mine. I bet one of those pesty");
                Console.WriteLine("rock monsters have it.");
                Console.WriteLine("Will you go fecth it for me? I will reward you with " + reward + " coins.");
                Console.WriteLine("");
                Console.WriteLine("Yes or no");
                string choice = Console.ReadLine();

                if (choice.Equals("Yes") || choice.Equals("yes"))
                {
                    Console.WriteLine("Oh great! Be sure not to let that pesty rock monster to get away.");
                    Console.WriteLine("Come back to me once you have the key.");
                    menu.start(menu, shop, player, fishing, woodcut, mine, monster, quests, save, load, farm);
                }
                else if (choice.Equals("No") || choice.Equals("no"))
                {
                    Console.WriteLine("Huh, well then. I guess I'll ask someone else!");
                    questMenu(player, menu, shop, fishing, woodcut, mine, monster, quests, save, load, farm);
                }
                else
                {
                    Console.WriteLine("Invalid option!");
                    questMenu(player, menu, shop, fishing, woodcut, mine, monster, quests, save, load, farm);
                }
            }
            else
            {
                Console.WriteLine("Ahhh, you have the key! I don't need to ask you to look for it now, great!");
                Console.WriteLine("I can now use this to sta... open my shed...");
                Console.WriteLine("Thank you traveller! Here is your reward.");
                Console.WriteLine("The old man hands you " + reward + " coins");
                player.gold += reward;
                player.inventory.Remove("Key");
                menu.start(menu, shop, player, fishing, woodcut, mine, monster, quests, save, load, farm);
            }
        }

        public void goblinHunter()
        {

            Random rand = new Random();
            int reward = rand.Next(20) + 2;

            Console.WriteLine("");
            Console.WriteLine("Welcome, traveller!");
            Console.WriteLine("");
            Console.WriteLine("I am in need of your help!");
            Console.WriteLine("");
            Console.WriteLine("You see, I may of betrayed the goblins up on the mountains ");
            Console.WriteLine("and now.... Well, they're angry at me.");
            Console.WriteLine("");
            Console.WriteLine("I need you to go and kill all of them for me. There's only 10 of them....");
            Console.WriteLine("It shouldn't be too hard for you!");
            Console.WriteLine("Will you help me please? Yes/No");
            Console.WriteLine("");
            string choice = Console.ReadLine();

            if(choice.Equals("Yes") || choice.Equals("yes"))
            {
                if (monster.goblinKills >= 10)
                {
                    Console.WriteLine("");
                    Console.WriteLine("You've killed them all!");
                    Console.WriteLine("You've saved me!");
                    Console.WriteLine("Thank you traveller!");
                    Console.WriteLine("Here's your reward " + reward + " gold.");
                    player.gold += reward;
                    monster.goblinKills = 0;
                    menu.start(menu, shop, player, fishing, woodcut, mine, monster, quests, save, load, farm);
                }
                else
                {
                    Console.WriteLine("");
                    Console.WriteLine("Thank you. Please come back to me once you've killed all of the goblins.");
                    menu.start(menu, shop, player, fishing, woodcut, mine, monster, quests, save, load, farm);
                }
            }
            else if (choice.Equals("No") || choice.Equals("no"))
            {
                Console.WriteLine("I guess I could take them out myself....");
                questMenu(player, menu, shop, fishing, woodcut, mine, monster, quests, save, load, farm);
            }
            else
            {
                Console.WriteLine("Invalid option!");
                questMenu(player, menu, shop, fishing, woodcut, mine, monster, quests, save, load, farm);
            }
        }

        public void breadMaker(Player player)
        {

            this.player = player;

            Random rand = new Random();
            int xp = rand.Next(15) + 1;

            Console.WriteLine("");
            Console.WriteLine("Hello! I need some help from you fast!");
            Console.WriteLine("Business today is too busy! I don't have time to go collect 3 ingredients ");
            Console.WriteLine("to make another loaf of bread.");
            Console.WriteLine("");
            Console.WriteLine("I need one of each egg, flour and a bucket of milk.");
            Console.WriteLine("I will reward you if you bring all 3 back to me.");
            Console.WriteLine("");
            Console.WriteLine("Will you help me? Yes/No");
            string choice = Console.ReadLine();

            if(choice.Equals("Yes") || choice.Equals("yes"))
            {
                if (player.inventory.Contains("Egg") && player.inventory.Contains("Pot of flour") && player.inventory.Contains("Bucket of milk"))
                {
                    Console.WriteLine("");
                    Console.WriteLine("Thank you!");
                    Console.WriteLine("You've just saved that poor old lady over there from waiting ");
                    Console.WriteLine("for another 40 minutes!");
                    Console.WriteLine("For your consideration, here is your reward.");
                    Console.WriteLine("You gained " + xp + " xp.");
                    player.xp += xp;
                    menu.start(menu, shop, player, fishing, woodcut, mine, monster, quests, save, load, farm);
                }
                else
                {
                    Console.WriteLine("");
                    Console.WriteLine("Thank you! Please come back once you have all the ingredients.");
                    menu.start(menu, shop, player, fishing, woodcut, mine, monster, quests, save, load, farm);
                }
            }
            else if (choice.Equals("No") || choice.Equals("no"))
            {
                Console.WriteLine("");
                Console.WriteLine("Then please leave! I have customers waiting!");
                questMenu(player, menu, shop, fishing, woodcut, mine, monster, quests, save, load, farm);
            }
            else
            {
                Console.WriteLine("");
                Console.WriteLine("Invalid option!");
                questMenu(player, menu, shop, fishing, woodcut, mine, monster, quests, save, load, farm);
            }
        }
    }
}
