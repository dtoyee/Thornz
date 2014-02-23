using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RPG_Game
{
    class Menu
    {

        private Menu menu;
        private Shop shop;
        private Player player;
        private Fishing fishing;
        private WoodCut woodcut;
        private Mine mine;
        private Monster monster;
        private Quests quests;
        private Save save;
        private Load load;
        private Farm farm;

        public void start(Menu menu, Shop shop, Player player, Fishing fishing, WoodCut woodcut, Mine mine, Monster monster, Quests quests, Save save, Load load, Farm farm)
        {

            this.menu = menu;
            this.shop = shop;
            this.player = player;
            this.fishing = fishing;
            this.woodcut = woodcut;
            this.mine = mine;
            this.monster = monster;
            this.quests = quests;
            this.save = save;
            this.load = load;
            this.farm = farm;

            Console.WriteLine("--------------------------");
            Console.WriteLine("| Shop    | buy or sell  |");
            Console.WriteLine("|  WC     | wood cut     |");
            Console.WriteLine("| Fish    | fish         |");
            Console.WriteLine("| Mine    | mine         |");
            Console.WriteLine("| Farm    | farm         |");
            Console.WriteLine("| Fight   | monsters     |");
            Console.WriteLine("| Quests  | quests       |");
            Console.WriteLine("| Stats   | player stats |");
            Console.WriteLine("| Save    | save game    |");
            Console.WriteLine("| Load    | load game    |");
            Console.WriteLine("| Exit    | exit         |");
            Console.WriteLine("--------------------------");
            Console.WriteLine("");
            Console.WriteLine("What would you like to do?");

            String choice = Console.ReadLine();

            if (choice.Equals("Shop") || choice.Equals("shop"))
            {
                shop.shopMenu(player, fishing, shop, menu, woodcut, mine, monster, quests, save, load, farm);
            }
            else if (choice.Equals("WC") || choice.Equals("wc"))
            {
                woodcut.woodCut(shop, player, menu, fishing, woodcut, mine, monster, quests, save, load, farm);
            }
            else if (choice.Equals("Fish") || choice.Equals("fish"))
            {
                fishing.startFishing(player, menu, shop, fishing, woodcut, mine, monster, quests, save, load, farm);
            }
            else if(choice.Equals("Stats") || choice.Equals("stats"))
            {
                player.getStats(menu, shop, player, fishing, woodcut, mine, monster, quests, save, load, farm);
            }
            else if (choice.Equals("Mine") || choice.Equals("mine"))
            {
                mine.playerMine(player, menu, shop, fishing, woodcut, mine, monster, quests, save, load, farm);
            }
            else if (choice.Equals("Farm") || choice.Equals("farm"))
            {
                farm.farmMenu(player, menu, shop, fishing, woodcut, mine, monster, quests, save, load, farm);
            }
            else if(choice.Equals("Fight") || choice.Equals("fight"))
            {
                monster.monsterMenu(player, menu, shop, fishing, woodcut, mine, monster, quests, save, load, farm);
            }else if(choice.Equals("Quests") || choice.Equals("quests"))
            {
                quests.questMenu(player, menu, shop, fishing, woodcut, mine, monster, quests, save, load, farm);
            }
            else if (choice.Equals("Exit") || choice.Equals("exit"))
            {
                System.Environment.Exit(0);
            }
            else if (choice.Equals("Save") || choice.Equals("save"))
            {
                save.saveGame(player, menu, shop, fishing, woodcut, mine, monster, quests, save, load, farm);
            }
            else if (choice.Equals("Load") || choice.Equals("load"))
            {
                load.loadGame(player, menu, shop, fishing, woodcut, mine, monster, quests, save, load, farm);
            }
            else
            {
                Console.WriteLine("Invalid option!");
                menu.start(menu, shop, player, fishing, woodcut, mine, monster, quests, save, load, farm);
            }
        }
    }
}
