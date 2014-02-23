using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RPG_Game
{
    class Monster
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

        public Random rand = new Random();
        public int goblinKills = 0;

        public void monsterMenu(Player player, Menu menu, Shop shop, Fishing fishing, WoodCut woodcut, Mine mine, Monster monster, Quests quests, Save save, Load load, Farm farm)
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
            Console.WriteLine("You look around and see different types of monsters.");
            Console.WriteLine("");
            Console.WriteLine("1. Goblin - Lvl 1");
            Console.WriteLine("2. Evil Chicken - Lvl 1");
            Console.WriteLine("3. Toodle - Lvl 2");
            Console.WriteLine("4. Exit");
            Console.WriteLine("");
            Console.WriteLine("Which number would you like to fight? Choose the number.");
            string choice = Console.ReadLine();

            if(choice.Equals("1"))
            {
                goblin(player);
            }
            else if(choice.Equals("2")){
                evilChicken(player);
            }
            else if(choice.Equals("3"))
            {
                toodle(player);
            }
            else if(choice.Equals("4")){
                menu.start(menu, shop, player, fishing, woodcut, mine, monster, quests, save, load, farm);
            }
            else
            {
                Console.WriteLine("Invalid choice!");
                monsterMenu(player, menu, shop, fishing, woodcut, mine, monster, quests, save, load, farm);
            }
        }

        public void rockMonster(Player player)
        {

            string name = "Rock Monster";
            int monsterHealth = 30;
            int level = 7;
            int strength = 15;

            string[] drops = new string[] {"Key","Rod","Axe"};
            string drop = drops[rand.Next(drops.Length)];

            while(player.health >= 1){

                int rockMonsterDamange = rand.Next(8) + 1 * strength / player.defence;
                int playerDamage = player.playerStrength * rand.Next(3) / 2;

                Console.WriteLine("A " +  name + " appears!");
                Console.WriteLine("He is level " + level + ". Do you wish to fight him? Yes/No");
                string choice = Console.ReadLine();
                
                if(choice.Equals("Yes") || choice.Equals("yes"))
                {

                    Console.WriteLine("The rock monster hits you for " + rockMonsterDamange);
                    player.health -= rockMonsterDamange;
                    Console.WriteLine("Your health: " + player.health);
                    Console.WriteLine("");
                    Console.WriteLine("You hit the rock monster for " + playerDamage);
                    monsterHealth -= playerDamage;
                    Console.WriteLine("Rock monsters health: " + monsterHealth);

                    if(player.health <= 0){
                        Console.WriteLine("You died!");
                        Console.WriteLine("Press any key to continue.");
                        Console.ReadLine();
                    }
                    else if (monsterHealth <= 0)
                    {
                        Console.WriteLine("You killed the " + name + "!");
                        Console.WriteLine("You picked up a " + drop + ".");
                        player.inventory.Add(drop);
                        player.xp += 30;
                        player.monsterKills++;
                        monsterMenu(player, menu, shop, fishing, woodcut, mine, monster, quests, save, load, farm);
                    }
                    
                }
                else if (choice.Equals("No") || choice.Equals("no"))
                {
                    Console.WriteLine("You decide to run away from the rock monster.");
                    menu.start(menu, shop, player, fishing, woodcut, mine, monster, quests, save, load, farm);
                }
                else
                {
                    Console.WriteLine("That wasn't an answer.");
                    rockMonster(player);
                }
            }
        }

        public void treeSpirit(Player player)
        {
            this.player = player;

            string name = "Tree Spirit";
            int monsterHealth = 15;
            int level = 3;
            int strength = 5;

            string[] drops = new string[] {"Log","Axe"};
            string drop = drops[rand.Next(drops.Length)];

            while(player.health >= 1){

                int treeSpiritDamange = rand.Next(4) + 1 * strength / player.defence;
                int playerDamage = player.playerStrength * rand.Next(3) / 2;

                Console.WriteLine("A " +  name + " appears!");
                Console.WriteLine("He is level " + level + ". Do you wish to fight him? Yes/No");
                string choice = Console.ReadLine();
                
                if(choice.Equals("Yes") || choice.Equals("yes"))
                {

                    Console.WriteLine("The rock monster hits you for " + treeSpiritDamange);
                    player.health -= treeSpiritDamange;
                    Console.WriteLine("Your health: " + player.health);
                    Console.WriteLine("");
                    Console.WriteLine("You hit the tree spirit for " + playerDamage);
                    monsterHealth -= playerDamage;
                    Console.WriteLine("Tree spirits health: " + monsterHealth);

                    if(player.health <= 0){
                        Console.WriteLine("You died!");
                        Console.WriteLine("Press any key to continue.");
                        Console.ReadLine();
                    }
                    else if (monsterHealth <= 0)
                    {
                        Console.WriteLine("You killed the " + name + "!");
                        Console.WriteLine("You picked up a " + drop + ".");
                        player.inventory.Add(drop);
                        player.xp += 15;
                        player.monsterKills++;
                        menu.start(menu, shop, player, fishing, woodcut, mine, monster, quests, save, load, farm);
                    }
                    
                }
                else if (choice.Equals("No") || choice.Equals("no"))
                {
                    Console.WriteLine("You decide to run away from the tree spirit.");
                    menu.start(menu, shop, player, fishing, woodcut, mine, monster, quests, save, load, farm);
                }
                else
                {
                    Console.WriteLine("That wasn't an answer.");
                    monsterMenu(player, menu, shop, fishing, woodcut, mine, monster, quests, save, load, farm);
                }
            }
        }

        public void goblin(Player player)
        {

            this.player = player;

            string name = "Goblin";
            int monsterHealth = 7;
            int level = 1;
            int strength = 3;
            int coinDrop = rand.Next(3) + 1;

            while (player.health >= 1)
            {

                int goblinDamange = rand.Next(4) + 1 * strength / player.defence;
                int playerDamage = player.playerStrength * rand.Next(3) / 2;

                Console.WriteLine("You found a " + name);
                Console.WriteLine("He is level " + level + ". Do you wish to fight him? Yes/No");
                string choice = Console.ReadLine();

                if (choice.Equals("Yes") || choice.Equals("yes"))
                {

                    Console.WriteLine("The " + name + " hits you for " + goblinDamange);
                    player.health -= goblinDamange;
                    Console.WriteLine("Your health: " + player.health);
                    Console.WriteLine("");
                    Console.WriteLine("You hit the " + name + " for " + playerDamage);
                    monsterHealth -= playerDamage;
                    Console.WriteLine(name + "s  health: " + monsterHealth);

                    if (player.health <= 0)
                    {
                        Console.WriteLine("You died!");
                        Console.WriteLine("Press any key to continue.");
                        Console.ReadLine();
                    }
                    else if (monsterHealth <= 0)
                    {
                        Console.WriteLine("You killed the " + name + "!");
                        Console.WriteLine("You picked up " + coinDrop + " gold.");
                        player.xp += 5;
                        goblinKills++;
                        player.gold += coinDrop;
                        player.monsterKills++;
                        menu.start(menu, shop, player, fishing, woodcut, mine, monster, quests, save, load, farm);
                    }

                }
                else if (choice.Equals("No") || choice.Equals("no"))
                {
                    Console.WriteLine("You decide to run away from the " + name +".");
                    menu.start(menu, shop, player, fishing, woodcut, mine, monster, quests, save, load, farm);
                }
                else
                {
                    Console.WriteLine("That wasn't an answer.");
                    monsterMenu(player, menu, shop, fishing, woodcut, mine, monster, quests, save, load, farm);
                }
            }
        }

        public void toodle(Player player)
        {

            this.player = player;

            string name = "Toodle";
            int monsterHealth = 12;
            int level = 2;
            int strength = 6;
            int coinDrop = rand.Next(6) + 1;

            while (player.health >= 1)
            {

                int toodleDamange = rand.Next(4) + 1 * strength / player.defence;
                int playerDamage = player.playerStrength * rand.Next(3) / 2;

                Console.WriteLine("You found a " + name);
                Console.WriteLine("He is level " + level + ". Do you wish to fight him? Yes/No");
                string choice = Console.ReadLine();

                if (choice.Equals("Yes") || choice.Equals("yes"))
                {

                    Console.WriteLine("");
                    Console.WriteLine("The " + name + " hits you for " + toodleDamange);
                    Console.WriteLine("");
                    player.health -= toodleDamange;
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
                        Console.WriteLine("You picked up " + coinDrop + " gold.");
                        Console.WriteLine("");
                        player.xp += 5;
                        player.gold += coinDrop;
                        player.monsterKills++;
                        menu.start(menu, shop, player, fishing, woodcut, mine, monster, quests, save, load, farm);
                    }

                }
                else if (choice.Equals("No") || choice.Equals("no"))
                {
                    Console.WriteLine("You decide to run away from the " + name + ".");
                    Console.WriteLine("");
                    menu.start(menu, shop, player, fishing, woodcut, mine, monster, quests, save, load, farm);
                }
                else
                {
                    Console.WriteLine("That wasn't an answer.");
                    Console.WriteLine("");
                    monsterMenu(player, menu, shop, fishing, woodcut, mine, monster, quests, save, load, farm);
                }
            }
        }

        public void evilChicken(Player player)
        {

            this.player = player;

            string name = "Evil Chicken";
            int monsterHealth = 5;
            int level = 1;
            int strength = 3;
            
            string[] drops = new string[]{"Feather","Egg"};
            string drop = drops[rand.Next(drops.Length)];

            while (player.health >= 1)
            {

                int chickenDamange = rand.Next(2) + 1 * strength / player.defence;
                int playerDamage = player.playerStrength * rand.Next(3) / 2;

                Console.WriteLine("You found a " + name);
                Console.WriteLine("He is level " + level + ". Do you wish to fight him? Yes/No");
                string choice = Console.ReadLine();

                if (choice.Equals("Yes") || choice.Equals("yes"))
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
                else if (choice.Equals("No") || choice.Equals("no"))
                {
                    Console.WriteLine("You decide to run away from the " + name + ".");
                    Console.WriteLine("");
                    menu.start(menu, shop, player, fishing, woodcut, mine, monster, quests, save, load, farm);
                }
                else
                {
                    Console.WriteLine("That wasn't an answer.");
                    Console.WriteLine("");
                    monsterMenu(player, menu, shop, fishing, woodcut, mine, monster, quests, save, load, farm);
                }
            }
        }
    }
}
