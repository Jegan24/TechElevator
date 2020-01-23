using System;
using System.Collections.Generic;
using System.Text;

namespace CLI_RPG
{
    class Player
    {
        public string name { get; private set; }
        public List<Item> items { get; private set; }
        public int gold { get; private set; }
        public int level { get; private set; }
        public int experience { get; private set; }


        public Player(string playerName)
        {
            gold = 0;
            level = 1;
            experience = 0;
            name = playerName;
        }
    }

    class Item
    {
        public int baseGoldValue { get; private set; }
        public string name { get; private set; }
    }

    class Gear : Item
    {
        public Attribute equipRequirements { get; private set; }
    }

    class Weapon : Gear
    {

    }

    class Armor : Gear
    {

    }

    class Consumable : Item
    {

    }
}
