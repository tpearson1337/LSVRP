using GTANetworkAPI;
using MyCustomGamemode.loggers;
using MyCustomGamemode.database;
using MyCustomGamemode.character;
using MyCustomGamemode.globals;
using MyCustomGamemode.jobs;
using System.Collections.Generic;

namespace MyCustomGamemode
{


    public class Main : Script
    {
        DBConnection db = new DBConnection();
        Constants Con = new Constants();
        public static List<MatRun> materialRuns = new List<MatRun>();

        [ServerEvent(Event.ResourceStart)]
        public void ResourceStart()
        {
            NAPI.Util.ConsoleOutput("GAMEMODE VERSION: LSVRP 1.0");

            // Start Map Run Loading BLAH
            NAPI.Util.ConsoleOutput("Loading Material Runs...");
            loadMatRuns();
            NAPI.Util.ConsoleOutput("Material Runs Loaded.");
            NAPI.Util.ConsoleOutput("Total MatRuns Loaded: " + materialRuns.Count);
        }
        /// <summary>
        ///  LOAD ALL IN GAME OBJECTS/HOUSES/GANGS/JOBS/MATERIALS RUNS
        /// </summary>
        private void loadMatRuns()
        {
            // Load from Database.
            materialRuns = db.getMaterialRuns();

            foreach (MatRun m in materialRuns)
            {
                Vector3 posp = new Vector3(m.pposX, m.pposY, m.pposZ);
                Vector3 posm = new Vector3(posp.X, posp.Y, posp.Z);
                posm.Z -= 2f;
                NAPI.Util.ConsoleOutput("Creating Text Label from: " + posp.ToString());
                //Pickup CreatePickup(PickupHash pickupHash, Vector3 pos, Vector3 rot, int amount, uint respawnTime, uint dimension = uint.MaxValue);
                NAPI.TextLabel.CreateTextLabel($"Press 'Y' to collect materials.", posp, 20, 3, 0, new Color(255, 255, 0, 245), false, 0);
                NAPI.Marker.CreateMarker(1, posm, new Vector3(), new Vector3(), 2f, new Color(0, 255, 0, 150));
            }
        }



        [ServerEvent(Event.PlayerConnected)]// Connection Event.

        public void ConnectionDisplayLogin(Client client)
        {
            //Update logs with connection informati
            ConnectionLogger L = new ConnectionLogger();
            PlayerLogin M = new PlayerLogin();

            string msg = $"Someone using the name{client.Name}  has connected to the server.";
            M.PlayerLoginWindow(client);
            L.LogMessageToFile(msg);
        }

        [ServerEvent(Event.PlayerDisconnected)]//Disconnect Event.

        public void ConnectionDisplayDisconnect(Client client, DisconnectionType type, string reason)
        {   //When player disconnectes launch the following functions

            //Update logs with disconnection information.
            string msg = $"Someone using the name {client.Name} has disconnected from the server.";
            ConnectionLogger L = new ConnectionLogger();
            L.LogMessageToFile(msg);
        }

        /// LOGIN EVENT AND DATA ORG

        [RemoteEvent("OnPlayerLoginAttempt")]
        public void OnPlayerLoginAttempt(Client player, string username, string password)
        {
            if (db.chkpswd(username, password))
            {
                Player p = db.pullUser(player, username);
                //Clear data slate before adding SQL values in case there was a player with the same ID that had logged off.
                player.ResetData("ID");
                player.ResetData("ADMIN");
                player.ResetData("FACTION");
                player.ResetData("MONEY");
                //Setting data to Client 
                player.SetData("ID", p.id);
                player.SetData("ADMIN", p.pAdmin);
                player.SetData("FACTION", p.pFaction);
                player.SetData("MONEY", p.pMoney);
                player.SetData("MATERIALS", p.pMats);

                player.TriggerEvent("LoginResult", 1);
            }
            else player.TriggerEvent("LoginResult", 0);
        }

        [RemoteEvent("OnPlayerRegisterAttempt")]
        public void OnPlayerRegisterAttempt(Client player, string username, string password)
        {
            if (db.playerExists(username))
            {
                player.TriggerEvent("RegisterResult", 0);
            }
            else
            {
                player.TriggerEvent("RegisterResult", 1);
                db.createUser(username, password);
                Player p = db.pullUser(player, username);// Pull default data now that it has been created
                //Clear data slate before adding SQL values in case there was a player with the same ID that had logged off.
                player.ResetData("ID");
                player.ResetData("ADMIN");
                player.ResetData("FACTION");
                player.ResetData("MONEY");
                // Setting data to Client
                player.SetData("ID", p.id);
                player.SetData("ADMIN", p.pMoney);
                player.SetData("FACTION", p.pFaction);
                player.SetData("MONEY", p.pMoney);
                player.SetData("MATERIALS", p.pMats);
            }

        }

        [RemoteEvent("PickupMats")]
        public void GetPlayerLocation(Client client)
        {
            materialRuns = db.getMaterialRuns();
            foreach (MatRun m in materialRuns)
            {
                Vector3 Matp = new Vector3(m.pposX, m.pposY, m.pposZ);
                Vector3 dropp = new Vector3(m.dposX, m.dposY, m.dposZ);
                if (Con.IsPlayerInRangeOf(client, Matp, 3))
                {
                    client.TriggerEvent("showcheckpoint",dropp);
                    return;
                }
            }
        }

        [ServerEvent(Event.PlayerEnterColshape)]
        public void PlayerEnterpoint(Client client)
        {
            foreach (MatRun m in materialRuns)
            {
                Vector3 dropp = new Vector3(m.dposX, m.dposY, m.dposZ);
                if (Con.IsPlayerInRangeOf(client, dropp, 3))
                {
                    client.SendChatMessage("You have received 250 materials.");
                    client.SetData("MATERIALS", +250);
                    return;
                }
            }
        }
        [Command("inventory")]
        public void CheckInventory(Client client)
        {
            int pmoney = client.GetData("MONEY");
            int pmats = client.GetData("MATERIALS");
            client.SendChatMessage("|-----------Temporary Inventory-----------|");
            client.SendChatMessage($"|-Money:${pmoney}-Materials:{pmats}-------|");
        }
    }//Main
}