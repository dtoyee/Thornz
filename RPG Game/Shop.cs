using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RPG_Game
{
    class Shop
    {

        private Menu menu;
        private Player player;
        private Fishing fishing;
        private Shop shop;
        private WoodCut woodcut;
        private Mine mine;
        private Monster monster;
        private Quests quests;
        private Save save;
        private Load load;
        private Farm farm;

        public void shopMenu(Player player, Fishing fishing, Shop shop, Menu menu, WoodCut woodcut, Mine mine, Monster monster, Quests quests, Save save, Load load, Farm farm)
        {

            this.menu = menu;
            this.player = player;
            this.fishing = fishing;
            this.shop = shop;
            this.woodcut = woodcut;
            this.mine = mine;
            this.monster = monster;
            this.quests = quests;
            this.save = save;
            this.load = load;
            this.farm = farm;

            Console.WriteLine("Welcome to the shop!");
            Console.WriteLine("Would you like to buy or sell?");
            Console.WriteLine("");
            Console.WriteLine("We also have a good selection of higher level weapons (unsellable).");
            Console.WriteLine("Would you like to see them? Yes/No");
            Console.WriteLine("");
            String choice = Console.ReadLine();

            if(choice.Equals("Buy") || choice.Equals("buy")){
                buy();
            }
            else if (choice.Equals("Sell") || choice.Equals("sell"))
            {
                sell();
            }
            else if (choice.Equals("No") || choice.Equals("no"))
            {
                menu.start(menu, shop, player, fishing, woodcut, mine, monster, quests, save, load, farm);
            }
            else
            {
                Console.WriteLine("Invalid input!");
                shopMenu(player, fishing, shop, menu, woodcut, mine, monster, quests, save, load, farm);
            }
        }

        public void buy()
        {

            Console.WriteLine("What would you like to buy?");
            Console.WriteLine("");

            Console.WriteLine("-----------------------");
            Console.WriteLine("|                     |");
            Console.WriteLine("|      WEAPONS        |");
            Console.WriteLine("|   Axe   | 70 coins  |");
            Console.WriteLine("|  Sword  | 50 coins  |");
            Console.WriteLine("|  Knife  | 30 coins  |");
            Console.WriteLine("|                     |");
            Console.WriteLine("|      TOOLS          |");
            Console.WriteLine("| Pickaxe | 50 coins  |");
            Console.WriteLine("|   Rod   | 30 coins  |");
            Console.WriteLine("|                     |");
            Console.WriteLine("|       ARMOUR        |");
            Console.WriteLine("| Bronze  | 60 coins  |");
            Console.WriteLine("|  Iron   | 80 coins  |");
            Console.WriteLine("|  Steel  | 100 coins |");
            Console.WriteLine("|                     |");
            Console.WriteLine("|       MISC          |");
            Console.WriteLine("| Bucket  | 10 coins  |");
            Console.WriteLine("|  Pot    | 10 coins  |");
            Console.WriteLine("|                     |");
            Console.WriteLine("|  Exit   |           |");
            Console.WriteLine("-----------------------");
            Console.WriteLine("");
            String choice = Console.ReadLine();

            if(choice.Equals("Axe") || choice.Equals("axe")){
                if(player.gold >= 70){

                    player.gold -= 70;
                    player.inventory.Add("Axe");

                    Console.WriteLine("You bought an axe.");
                    Console.WriteLine("You have " + player.gold + " coins.");

                    menu.start(menu, shop, player, fishing, woodcut, mine, monster, quests, save, load, farm);
                }
                else
                {
                    Console.WriteLine("Sorry, you do not have enough coins.");
                    shopMenu(player, fishing, shop, menu, woodcut, mine, monster, quests, save, load, farm);
                }
            }
            else if (choice.Equals("Pickaxe") || choice.Equals("pickaxe"))
            {
                if (player.gold >= 50)
                {

                    player.gold -= 50;
                    player.inventory.Add("Pickaxe");

                    Console.WriteLine("You bought a pickaxe.");
                    Console.WriteLine("You have " + player.gold + " coins.");

                    menu.start(menu, shop, player, fishing, woodcut, mine, monster, quests, save, load, farm);
                }
                else
                {
                    Console.WriteLine("Sorry, you do not have enough coins.");
                    shopMenu(player, fishing, shop, menu, woodcut, mine, monster, quests, save, load, farm);
                }
            }
            else if (choice.Equals("Sword") || choice.Equals("sword"))
            {
                if (player.gold >= 50)
                {

                    player.gold -= 50;
                    player.playerStrength += 4;
                    player.inventory.Add("Sword");

                    Console.WriteLine("You bought a sword.");
                    Console.WriteLine("You have " + player.gold + " coins.");

                    menu.start(menu, shop, player, fishing, woodcut, mine, monster, quests, save, load, farm);
                }
                else
                {
                    Console.WriteLine("Sorry, you do not have enough coins.");
                    shopMenu(player, fishing, shop, menu, woodcut, mine, monster, quests, save, load, farm);
                }
            }
            else if (choice.Equals("Knife") || choice.Equals("knife"))
            {
                if (player.gold >= 30)
                {

                    player.gold -= 30;
                    player.playerStrength += 2;
                    player.inventory.Add("Knife");

                    Console.WriteLine("You bought a knife.");
                    Console.WriteLine("You have " + player.gold + " coins.");
                    foreach (var i in player.inventory)
                    {
                        Console.WriteLine("Your inventory contains a " + i);
                    }
                    menu.start(menu, shop, player, fishing, woodcut, mine, monster, quests, save, load, farm);
                }
                else
                {
                    Console.WriteLine("Sorry, you do not have enough coins.");
                    shopMenu(player, fishing, shop, menu, woodcut, mine, monster, quests, save, load, farm);
                }
            }
            else if (choice.Equals("Rod") || choice.Equals("rod"))
            {
                if (player.gold >= 30)
                {

                    player.gold -= 30;
                    player.inventory.Add("Rod");

                    Console.WriteLine("You bought a rod.");
                    Console.WriteLine("You have " + player.gold + " coins.");

                    menu.start(menu, shop, player, fishing, woodcut, mine, monster, quests, save, load, farm);
                }
                else
                {
                    Console.WriteLine("Sorry, you do not have enough coins.");
                    shopMenu(player, fishing, shop, menu, woodcut, mine, monster, quests, save, load, farm);
                }
            }
            else if (choice.Equals("Bronze") || choice.Equals("bronze"))
            {
                if (player.gold >= 60)
                {

                    player.gold -= 60;
                    player.defence += 5;
                    player.inventory.Add("Bronze Armour");

                    Console.WriteLine("You bought a set of bronze armour.");
                    Console.WriteLine("You have " + player.gold + " coins.");

                    menu.start(menu, shop, player, fishing, woodcut, mine, monster, quests, save, load, farm);
                }
                else
                {
                    Console.WriteLine("Sorry, you do not have enough coins.");
                    shopMenu(player, fishing, shop, menu, woodcut, mine, monster, quests, save, load, farm);
                }
            }
            else if (choice.Equals("Iron") || choice.Equals("iron"))
            {
                if (player.gold >= 80)
                {

                    player.gold -= 80;
                    player.defence += 12;
                    player.inventory.Add("Iron Armour");

                    Console.WriteLine("You bought a set of iron armour.");
                    Console.WriteLine("You have " + player.gold + " coins.");

                    menu.start(menu, shop, player, fishing, woodcut, mine, monster, quests, save, load, farm);
                }
                else
                {
                    Console.WriteLine("Sorry, you do not have enough coins.");
                    shopMenu(player, fishing, shop, menu, woodcut, mine, monster, quests, save, load, farm);
                }
            }
            else if (choice.Equals("Steel") || choice.Equals("steel"))
            {
                if (player.gold >= 100)
                {

                    player.gold -= 100;
                    player.defence += 20;
                    player.inventory.Add("Steel Armour");

                    Console.WriteLine("You bought a set of steel armour.");
                    Console.WriteLine("You have " + player.gold + " coins.");

                    menu.start(menu, shop, player, fishing, woodcut, mine, monster, quests, save, load, farm);
                }
                else
                {
                    Console.WriteLine("Sorry, you do not have enough coins.");
                    shopMenu(player, fishing, shop, menu, woodcut, mine, monster, quests, save, load, farm);
                }
            }
            else if (choice.Equals("Bucket") || choice.Equals("bucket"))
            {
                if (player.gold >= 10)
                {

                    player.gold -= 10;
                    player.inventory.Add("Bucket");

                    Console.WriteLine("You bought a bucket.");
                    Console.WriteLine("You have " + player.gold + " coins.");

                    menu.start(menu, shop, player, fishing, woodcut, mine, monster, quests, save, load, farm);
                }
                else
                {
                    Console.WriteLine("Sorry, you do not have enough coins.");
                    shopMenu(player, fishing, shop, menu, woodcut, mine, monster, quests, save, load, farm);
                }
            }
            else if (choice.Equals("Pot") || choice.Equals("pot"))
            {
                if (player.gold >= 10)
                {

                    player.gold -= 10;
                    player.inventory.Add("Pot");

                    Console.WriteLine("You bought a pot.");
                    Console.WriteLine("You have " + player.gold + " coins.");

                    menu.start(menu, shop, player, fishing, woodcut, mine, monster, quests, save, load, farm);
                }
                else
                {
                    Console.WriteLine("Sorry, you do not have enough coins.");
                    shopMenu(player, fishing, shop, menu, woodcut, mine, monster, quests, save, load, farm);
                }
            }
            else if (choice.Equals("Exit") || choice.Equals("exit"))
            {
                menu.start(menu, shop, player, fishing, woodcut, mine, monster, quests, save, load, farm);
            }
            else
            {
                Console.WriteLine("Invalid choice.");
                shopMenu(player, fishing, shop, menu, woodcut, mine, monster, quests, save, load, farm);
            }
        }

        public void sell()
        {

            Console.WriteLine("What would you like to sell?");
            Console.WriteLine("");
            foreach (var i in player.inventory)
            {
                Console.WriteLine("Your inventory contains a " + i);
            }
            Console.WriteLine("");
            Console.WriteLine("-----------------------");
            Console.WriteLine("|                     |");
            Console.WriteLine("|      WEAPONS        |");
            Console.WriteLine("|   Axe   | 60 coins  |");
            Console.WriteLine("| Pickaxe | 40 coins  |");
            Console.WriteLine("|  Sword  | 40 coins  |");
            Console.WriteLine("|  Knife  | 20 coins  |");
            Console.WriteLine("|   Rod   | 20 coins  |");
            Console.WriteLine("|                     |");
            Console.WriteLine("|       ARMOUR        |");
            Console.WriteLine("| Bronze  | 40 coins  |");
            Console.WriteLine("|  Iron   | 60 coins  |");
            Console.WriteLine("|  Steel  | 80 coins  |");
            Console.WriteLine("|                     |");
            Console.WriteLine("|  Exit   |           |");
            Console.WriteLine("-----------------------");
            Console.WriteLine("");
            String choice = Console.ReadLine();

            if(choice.Equals("Axe") || choice.Equals("axe"))
            {
                if(player.inventory.Contains("Axe"))
                {

                    player.inventory.Remove("Axe");
                    player.gold += 60;

                    Console.WriteLine("You sell your axe.");
                    Console.WriteLine("You have " + player.gold + " coins.");

                    menu.start(menu, shop, player, fishing, woodcut, mine, monster, quests, save, load, farm);
                }
                else
                {
                    Console.WriteLine("Sorry, you do not have that item.");
                    shopMenu(player, fishing, shop, menu, woodcut, mine, monster, quests, save, load, farm);
                }
            }else if(choice.Equals("Pickaxe") || choice.Equals("pickaxe")){
                if (player.inventory.Contains("Pickaxe"))
                {

                    player.inventory.Remove("Pickaxe");
                    player.gold += 50;

                    Console.WriteLine("You sell your pickaxe.");
                    Console.WriteLine("You have " + player.gold + " coins.");

                    menu.start(menu, shop, player, fishing, woodcut, mine, monster, quests, save, load, farm);
                }
                else
                {
                    Console.WriteLine("Sorry, you do not have that item.");
                    shopMenu(player, fishing, shop, menu, woodcut, mine, monster, quests, save, load, farm);
                }
            }
            else if (choice.Equals("Sword") || choice.Equals("sword"))
            {
                if (player.inventory.Contains("Sword"))
                {

                    player.inventory.Remove("Sword");
                    player.gold += 50;

                    Console.WriteLine("You sell your sword.");
                    Console.WriteLine("You have " + player.gold + " coins.");

                    menu.start(menu, shop, player, fishing, woodcut, mine, monster, quests, save, load, farm);
                }
                else
                {
                    Console.WriteLine("Sorry, you do not have that item.");
                    shopMenu(player, fishing, shop, menu, woodcut, mine, monster, quests, save, load, farm);
                }
            }
            else if (choice.Equals("Knife") || choice.Equals("knife"))
            {
                if (player.inventory.Contains("Knife"))
                {

                    player.inventory.Remove("Knife");
                    player.gold += 20;

                    Console.WriteLine("You sell your knife.");
                    Console.WriteLine("You have " + player.gold + " coins.");

                    menu.start(menu, shop, player, fishing, woodcut, mine, monster, quests, save, load, farm);
                }
                else
                {
                    Console.WriteLine("Sorry, you do not have that item.");
                    shopMenu(player, fishing, shop, menu, woodcut, mine, monster, quests, save, load, farm);
                }
            }
            else if (choice.Equals("Rod") || choice.Equals("rod"))
            {
                if (player.inventory.Contains("Rod"))
                {

                    player.inventory.Remove("Rod");
                    player.gold += 20;

                    Console.WriteLine("You sell your rod.");
                    Console.WriteLine("You have " + player.gold + " coins.");

                    menu.start(menu, shop, player, fishing, woodcut, mine, monster, quests, save, load, farm);
                }
                else
                {
                    Console.WriteLine("Sorry, you do not have that item.");
                    shopMenu(player, fishing, shop, menu, woodcut, mine, monster, quests, save, load, farm);
                }
            }
            else if (choice.Equals("Bronze") || choice.Equals("bronze"))
            {
                if (player.inventory.Contains("Bronze Armour"))
                {

                    player.inventory.Remove("Bronze Armour");
                    player.gold += 40;

                    Console.WriteLine("You sell your bronze armour.");
                    Console.WriteLine("You have " + player.gold + " coins.");

                    menu.start(menu, shop, player, fishing, woodcut, mine, monster, quests, save, load, farm);
                }
                else
                {
                    Console.WriteLine("Sorry, you do not have that item.");
                    shopMenu(player, fishing, shop, menu, woodcut, mine, monster, quests, save, load, farm);
                }
            }
            else if (choice.Equals("Iron") || choice.Equals("iron"))
            {
                if (player.inventory.Contains("Iron Armour"))
                {

                    player.inventory.Remove("Iron Armour");
                    player.gold += 60;

                    Console.WriteLine("You sell your iron armour.");
                    Console.WriteLine("You have " + player.gold + " coins.");

                    menu.start(menu, shop, player, fishing, woodcut, mine, monster, quests, save, load, farm);
                }
                else
                {
                    Console.WriteLine("Sorry, you do not have that item.");
                    shopMenu(player, fishing, shop, menu, woodcut, mine, monster, quests, save, load, farm);
                }
            }
            else if (choice.Equals("Steel") || choice.Equals("steel"))
            {
                if (player.inventory.Contains("Steel Armour"))
                {

                    player.inventory.Remove("Steel Armour");
                    player.gold += 80;

                    Console.WriteLine("You sell your steel armour.");
                    Console.WriteLine("You have " + player.gold + " coins.");

                    menu.start(menu, shop, player, fishing, woodcut, mine, monster, quests, save, load, farm);
                }
                else
                {
                    Console.WriteLine("Sorry, you do not have that item.");
                    shopMenu(player, fishing, shop, menu, woodcut, mine, monster, quests, save, load, farm);
                }
            }
            else if (choice.Equals("Exit") || choice.Equals("exit"))
            {
                menu.start(menu, shop, player, fishing, woodcut, mine, monster, quests, save, load, farm);
            }
            else
            {
                Console.WriteLine("Invalid choice.");
                sell();
            }
        }
    }
}
