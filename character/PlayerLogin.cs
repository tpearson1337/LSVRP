using System;
using GTANetworkAPI;
using MyBeastSolution.Server.globals;
using MyBeastSolution.Server.database;
using MyBeastSolution.Server.loggers;

namespace MyBeastSolution.Server.character
{
    public class PlayerLogin
    {
        public PlayerLogin()
        {
            
        }
        public void PlayerLoginWindow(Client client)
        {
            client.SendChatMessage("Please Register or Login");
            client.TriggerEvent("showregisterwindow");
            NAPI.Util.ConsoleOutput($"launched login window");


        }
        public void InsertPlayerData(Client client,int pid,string pname,string ppassword,int padmin,int pmoney,int pfaction)
        {
          
        }
        public void loggedin(Client client, string username,string password)
        {

        }
    }
}
