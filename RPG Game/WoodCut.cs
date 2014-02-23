using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RPG_Game
{
    class WoodCut
    {

        private Shop shop;
        private Player player;
        private Menu menu;
        private Fishing fishing;
        private WoodCut woodcut;
        private Mine mine;
        private Monster monster;
        private Quests quests;
        private Save save;
        private Load load;
        private Farm farm;

        public void woodCut(Shop shop, Player player, Menu menu, Fishing fishing, WoodCut woodcut, Mine mine, Monster monster, Quests quests, Save save, Load load, Farm farm)
        {

            this.shop = shop;
            this.player = player;
            this.menu = menu;
            this.fishing = fishing;
            this.woodcut = woodcut;
            this.mine = mine;
            this.monster = monster;
            this.quests = quests;
            this.save = save;
            this.load = load;
            this.farm = farm;

            if (player.inventory.Contains("Axe"))
            {

                Random rand = new Random();
                int n = rand.Next(10) + 1;
                int x = rand.Next(3) + 1;

                if(n == 4)
                {
                    monster.treeSpirit(player);

                }else
                {
                    for (int i = 0; i < n; i++)
                    {
                        Console.WriteLine("You swing your axe at the tree and get a log.");
                        player.inventory.Add("Log");
                    }
                    player.xp += x;
                    player.levelUP();

                    Console.WriteLine("You get a total of " + n + " logs.");
                    Console.WriteLine(n + " logs have been added to your inventory.");
                    Console.WriteLine("You gained " + x + " XP");

                    menu.start(menu, shop, player, fishing, woodcut, mine, monster, quests, save, load, farm);
                }
            }
            else
            {
                Console.WriteLine("You do not have an axe.");
                Console.WriteLine("Do you want to visit the shop? Y/N");
                String choice = Console.ReadLine();

                if (choice.Equals("Yes") || choice.Equals("yes"))
                {
                    shop.shopMenu(player, fishing, shop, menu, woodcut, mine, monster, quests, save, load, farm);
                }
                else if (choice.Equals("No") || choice.Equals("no"))
                {
                    menu.start(menu, shop, player, fishing, woodcut, mine, monster, quests, save, load, farm);
                }
                else
                {
                    Console.WriteLine("That wasn't an option.");
                    woodCut(shop, player, menu, fishing, woodcut, mine, monster, quests, save, load, farm);
                }
            }
        }
    }
}
