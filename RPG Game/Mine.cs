using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RPG_Game
{
    class Mine
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

        public void playerMine(Player player, Menu menu, Shop shop, Fishing fishing, WoodCut woodcut, Mine mine, Monster monster, Quests quests, Save save, Load load, Farm farm)
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

            if (player.inventory.Contains("Pickaxe"))
            {

                Random rand = new Random();

                string[] ores = new string[] {"Coal","Iron","Copper","Gold","Lead","Quartz"};
                string ore = ores[rand.Next(ores.Length)];
                int xp = rand.Next(5) + 1;
                int monsterNumber = rand.Next(20) + 1;

                if (monsterNumber == 9)
                {
                    monster.rockMonster(player);
                }
                else
                {

                    Console.WriteLine("You mine some " + ore);
                    player.inventory.Add(ore);
                    player.xp += xp;
                    player.levelUP();
                    Console.WriteLine("You gained " + xp + " xp");

                    Console.WriteLine("Continue mining? Yes/No");
                    string choice = Console.ReadLine();

                    if (choice.Equals("Yes") || choice.Equals("yes"))
                    {
                        playerMine(player, menu, shop, fishing, woodcut, mine, monster, quests, save, load, farm);
                    }
                    else if (choice.Equals("No") || choice.Equals("no"))
                    {
                        menu.start(menu, shop, player, fishing, woodcut, mine, monster, quests, save, load, farm);
                    }
                    else
                    {
                        Console.WriteLine("That wasn't an option.");
                        playerMine(player, menu, shop, fishing, woodcut, mine, monster, quests, save, load, farm);
                    }
                }
            }
            else
            {
                Console.WriteLine("You do not have a pickaxe.");
                Console.WriteLine("Do you want to visit the shop? Yes/No");
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
                    playerMine(player, menu, shop, fishing, woodcut, mine, monster, quests, save, load, farm);
                }
            }
        }
    }
}
