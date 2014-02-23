using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RPG_Game
{
    class Game
    {
        
        private static Shop shop = new Shop();
        private static Player player = new Player();
        private static Fishing fishing = new Fishing();
        private static WoodCut woodcut = new WoodCut();
        private static Mine mine = new Mine();
        private static Monster monster = new Monster();
        private static Quests quests = new Quests();
        private static Save save = new Save();
        private static Load load = new Load();
        private static Farm farm = new Farm();

        public static void Main(string[] args)
        {
            Menu menu = new Menu();

            menu.start(menu, shop, player, fishing, woodcut, mine, monster, quests, save, load, farm);
        }
    }
}
