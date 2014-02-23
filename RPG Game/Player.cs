using System;
using System.Collections;
using System.Linq;
using System.Text;

namespace RPG_Game
{
    class Player
    {

        public int gold = 100;
        public int health = 20;
        public int level = 1;
        public int xp = 0;
        public int monsterKills = 0;
        public int attackLevel = 1;
        public int playerStrength = 5;
        public int defence = 5;
        public ArrayList inventory = new ArrayList();

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

        public void getStats(Menu menu, Shop shop, Player player, Fishing fishing, WoodCut woodcut, Mine mine, Monster monster, Quests quests, Save save, Load load, Farm farm)
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

            Console.WriteLine("----Stats----");
            Console.WriteLine("Gold: " + gold + " coins");
            Console.WriteLine("Health: " + health);
            Console.WriteLine("Kills: " + monsterKills);
            Console.WriteLine("Attack Level: " + attackLevel);
            Console.WriteLine("Strength: " + playerStrength);
            Console.WriteLine("Defence: " + defence);
            Console.WriteLine("Level: " + level);
            Console.WriteLine("XP: " + xp);

            menu.start(menu, shop, player, fishing, woodcut, mine, monster, quests, save, load, farm);
        }

        public void levelUP()
        {

            if (level >= 10)
            {
                //Do nothing
            }
            else if (xp >= 10 && level == 1)
            {
                level++;
                attackLevel++;
                health += 5;
                playerStrength += 5;
                defence += 3;
                gold += 10;
                Console.WriteLine("You leveled up!");
            }
            else if (xp >= 29 && level == 2)
            {
                level++;
                attackLevel++;
                health += 5;
                playerStrength += 5;
                defence += 3;
                gold += 10;
                Console.WriteLine("You leveled up!");
            }
            else if (xp >= 69 && level == 3)
            {
                level++;
                attackLevel++;
                health += 5;
                playerStrength += 5;
                defence += 3;
                gold += 10;
                Console.WriteLine("You leveled up!");
            }
            else if (xp >= 109 && level == 4)
            {
                level++;
                attackLevel++;
                health += 5;
                playerStrength += 5;
                defence += 3;
                gold += 10;
                Console.WriteLine("You leveled up!");
            }
            else if (xp >= 159 && level == 5)
            {
                level++;
                attackLevel++;
                health += 5;
                playerStrength += 5;
                defence += 3;
                gold += 10;
                Console.WriteLine("You leveled up!");
            }
            else if (xp >= 219 && level == 6)
            {
                level++;
                attackLevel++;
                health += 5;
                playerStrength += 5;
                defence += 3;
                gold += 10;
                Console.WriteLine("You leveled up!");
            }
            else if (xp >= 299 && level == 7)
            {
                level++;
                attackLevel++;
                health += 5;
                playerStrength += 5;
                defence += 3;
                gold += 10;
                Console.WriteLine("You leveled up!");
            }
            else if (xp >= 389 && level == 8)
            {
                level++;
                attackLevel++;
                health += 5;
                playerStrength += 5;
                defence += 3;
                gold += 10;
                Console.WriteLine("You leveled up!");
            }
            else if (xp >= 499 && level == 9)
            {
                level++;
                attackLevel++;
                health += 5;
                playerStrength += 5;
                defence += 3;
                gold += 10;
                Console.WriteLine("You leveled up!");
            }
        }
    }
}
