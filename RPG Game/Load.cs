using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RPG_Game
{
    class Load
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

        public void loadGame(Player player, Menu menu, Shop shop, Fishing fishing, WoodCut woodcut, Mine mine, Monster monster, Quests quests, Save save, Load load, Farm farm)
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

            const string f = "savedgame.txt";

            var lines = File.ReadAllLines(f);
            player.gold = Convert.ToInt32(lines[0]);
            player.health = Convert.ToInt32(lines[1]);
            player.level = Convert.ToInt32(lines[2]);
            player.xp = Convert.ToInt32(lines[3]);
            player.monsterKills = Convert.ToInt32(lines[4]);
            player.playerStrength = Convert.ToInt32(lines[5]);

            Console.WriteLine("Your game has been saved.");
            menu.start(menu, shop, player, fishing, woodcut, mine, monster, quests, save, load, farm);
        }
    }
}
