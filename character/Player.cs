using System;
using GTANetworkAPI;
using MyBeastSolution.Server.globals;
using MyBeastSolution.Server.loggers;
using MyBeastSolution.Server.database;
using MyBeastSolution.Server.character;

namespace MyBeastSolution.Server.character
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