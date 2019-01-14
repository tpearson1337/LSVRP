using System;
using GTANetworkAPI;
using MyBeastSolution.Server.database;
using MyBeastSolution.Server;


namespace MyBeastSolution.Server.character
{

    public class AdminCMDS :Script
    {
        
        public AdminCMDS()
        {
           
        }
        DBConnection db = new DBConnection();
        Main st = new Main();

        [Command("cc")]
        public void CmdCreateCar(Client client, string type)
        {
            if (st.Getplayerstat(client,"ADMIN") >0)
            {
                Vehicle newVehicle;
                uint myCarType = NAPI.Util.GetHashKey(type);
                newVehicle = NAPI.Vehicle.CreateVehicle(myCarType, client.Position.Around(5), 0, 7, 7);
                return;
            }
            else
            {
                client.SendChatMessage("You are not an admin.");
                return;
            }
        }

        [Command("setmats")]
        public void CmdSetMats(Client client, int amount)
        {
            if (st.Getplayerstat(client, "ADMIN") > 0)
            {
                int currentmats = st.Getplayerstat(client,"MATERIALS");
                st.Setplayerstat(client, "MATERIALS",currentmats += amount);
            }
            else
            {
                client.SendChatMessage("You are not an admin.");
                return;
            }
        }

        [Command("getpos")]
        public void GetPosition(Client client,string label)
        {
            if (client.GetData("ADMIN") > 0)
            {
                Vector3 PlayerPos = NAPI.Entity.GetEntityPosition(client);
                NAPI.Util.ConsoleOutput($"X: { PlayerPos.X}  Y: {PlayerPos.Y } Z:  { PlayerPos.Z} LABEL: {label}");
            }
            else
            {
                client.SendChatMessage("You are not an admin.");
            }
        }
        [Command("teleport")]
        public void teleport(Client client, Client target)
        {
            if (client.GetData("ADMIN") > 0)
            {
                Vector3 PlayerPos = NAPI.Entity.GetEntityPosition(target);
                client.Position = target.Position.Around(5);
                                            
            }
            else
            {
                client.SendChatMessage("You are not an admin.");  
            }

        }
        [Command("heal")]
        public void heal(Client client)
        {
            if (client.GetData("ADMIN") > 0)
            {
                client.Health = 100;

            }
            else
            {
                client.SendChatMessage("You are not an admin.");
            }

        }
        [Command("gethere")]
        public void gethere(Client client, Client target)
        {
            if (client.GetData("ADMIN") > 0)
            {
                Vector3 PlayerPos = NAPI.Entity.GetEntityPosition(client);
                target.Position = client.Position.Around(5);
            }
            else
            {
                client.SendChatMessage("You are not an admin.");
            }

        }
        //temp
        [Command("mat1")]
        public void mat1(Client client)
        {
            Vector3 pos = new Vector3(968.4285, -1625.152, 30.11069);
            client.Position = pos.Around(5);
        }

        [Command("creatematrun")]
        public void matruncreate(Client client,string name,int matamount, int price)
        {
            if (client.GetData("ADMIN") < 2) { client.SendChatMessage("~r~You are not Authorized to use this command."); return; }
            if (client.GetData("matpickuppos") == null)
            {
                Vector3 playerpos = client.Position;
                Vector3 pos = new Vector3(playerpos.X, playerpos.Y, playerpos.Z);
                client.SetData("Matpickuppos", pos);
                client.SetData("pmatamount", pos);
                client.SetData("pmatprice", pos);
                client.SetData("pmatname", name);
                client.SendChatMessage("~y~ Please go to preferred dropoff position and type /matdropoff.");
            }
            else
            {
                client.SendChatMessage("~r~You already have a matrun saved.");
                client.SendChatMessage("~r~If you want to restart type /clearmatsetup.");
            }


        }
        [Command("matdropoff")]
        public void matdropcreate(Client client)
        {
            if (client.GetData("ADMIN") < 2) { client.SendChatMessage("~r~You are not Authorized to use this command."); return; }
            if (client.GetData("matpickuppos") == null)
            {
                client.SendChatMessage("~r~You did not save a mat pickup first.");
                client.SendChatMessage("~r~Please go to preferred mat pickup position and type /creatematrun.");
            }
            else
            {
                Vector3 playerpos = client.Position;
                Vector3 pos = new Vector3(playerpos.X, playerpos.Y, playerpos.Z);
                Vector3 ppos = client.GetData("matpickuppos");
                int price = client.GetData("pmatprice");
                int matamount = client.GetData("pmatamount");
                string name = client.GetData("pmatname");
                client.SendChatMessage($"~y~ You have successfully created a materials run!");
                client.SendChatMessage($"~y~ Run Name:{name}");
                client.SendChatMessage($"~y~ Pickup Coord:{ppos}");
                client.SendChatMessage($"~y~ Dropoff Coord:{pos}");
                client.SendChatMessage($"~y~ Materials Given: {matamount}");
                client.SendChatMessage($"~y~ Price per package: {price}");
                db.createMatrun(name, ppos, pos, price, matamount);

                client.SetData("pmatname", null);
                client.SetData("matpickuppos", null);
                client.SetData("pmatprice", null);
                client.SetData("pmatamount", null);
            }
        }


        

    }
}