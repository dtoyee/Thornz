using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RPG_Game
{
    class Save
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

        public void saveGame(Player player, Menu menu, Shop shop, Fishing fishing, WoodCut woodcut, Mine mine, Monster monster, Quests quests, Save save, Load load, Farm farm)
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

            try
            {
                TextWriter tw = new StreamWriter("savedgame.txt");
                tw.WriteLine(player.gold);
                tw.WriteLine(player.health);
                tw.WriteLine(player.level);
                tw.WriteLine(player.xp);
                tw.WriteLine(player.monsterKills);
                tw.WriteLine(player.playerStrength);
                foreach (var i in player.inventory)
                {
                    tw.WriteLine(i);
                }

                tw.Close();
                Console.WriteLine("Your game has been saved.");
                menu.start(menu, shop, player, fishing, woodcut, mine, monster, quests, save, load, farm);
            }
            catch (Exception e)
            {
                Console.WriteLine("Error saving your game!");
                Console.WriteLine(e.Message);
                menu.start(menu, shop, player, fishing, woodcut, mine, monster, quests, save, load, farm);
            }
        }
    }
}
