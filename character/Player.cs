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
        //DATABASE VALUES
        public int id { get; set; }
        public string pName { get; set; }
        public int pAdmin { get; set; }
        public int pMoney { get; set; }
        public int pFaction { get; set; }
        public int pMats { get; set; }
        public double PX { get; set; }
        public double PY { get; set; }
        public double PZ { get; set; }

        //TEMPORARY VALUES
        public double MPX { get; set; }
        public double MPY { get; set; }
        public double MPZ { get; set; }
        public double MDX { get; set; }
        public double MDY { get; set; }
        public double MDZ { get; set; }

    }
}