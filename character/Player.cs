using System;
using GTANetworkAPI;
using MyCustomGamemode.globals;
using MyCustomGamemode.loggers;
using MyCustomGamemode.database;
using MyCustomGamemode.character;

namespace MyCustomGamemode.character
{
    public class Player
    {
        public int id { get; set; }
        public string pName { get; set; }
        public int pAdmin { get; set; }
        public int pMoney { get; set; }
        public int pFaction { get; set; }
        public int pMats { get; set; }

    }
}