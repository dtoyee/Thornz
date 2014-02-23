using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RPG_Game
{
    class Fishing
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

        public void startFishing(Player player, Menu menu, Shop shop, Fishing fishing, WoodCut woodcut, Mine mine, Monster monster, Quests quests, Save save, Load load, Farm farm)
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

            if (player.inventory.Contains("Rod"))
            {

                Random rand = new Random();
                string[] fish = new string[] { "Trout", "Salmon", "Lobster", "Shark", "Tuna" };
                string f = fish[rand.Next(fish.Length)];
                int x = rand.Next(3) + 1;

                Console.WriteLine("You manage to catch a " + f);
                player.inventory.Add(f);
                player.xp += x;
                player.levelUP();
                Console.WriteLine("You gained " + x + " XP");

                Console.WriteLine("Do you want to carry on fishing? Yes/No");
                String choice = Console.ReadLine();

                if (choice.Equals("Yes") || choice.Equals("yes"))
                {
                    startFishing(player, menu, shop, fishing, woodcut, mine, monster, quests, save, load, farm);
                }
                else if (choice.Equals("No") || choice.Equals("no"))
                {
                    menu.start(menu, shop, player, fishing, woodcut, mine, monster, quests, save, load, farm);
                }
                else
                {
                    Console.WriteLine("That wasn't an option.");
                    startFishing(player, menu, shop, fishing, woodcut, mine, monster, quests, save, load, farm);
                }
            }
            else
            {
                Console.WriteLine("You do not have a rod.");
                Console.WriteLine("Do you want to visit the shop? Yes/No");
                String choice = Console.ReadLine();

                if(choice.Equals("Yes") || choice.Equals("yes")){
                    shop.shopMenu(player, fishing, shop, menu, woodcut, mine, monster, quests, save, load, farm);
                }else if(choice.Equals("No") || choice.Equals("no")){
                    menu.start(menu, shop, player, fishing, woodcut, mine, monster, quests, save, load, farm);
                }else{
                    Console.WriteLine("That wasn't an option.");
                    startFishing(player, menu, shop, fishing, woodcut, mine, monster, quests, save, load, farm);
                }
            }
        }
    }
}
