using System;
using GTANetworkAPI;
using MyCustomGamemode.globals;
using MyCustomGamemode.database;
using MyCustomGamemode.loggers;

namespace MyCustomGamemode.character
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
