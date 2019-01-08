using System;
using GTANetworkAPI;


namespace MyCustomGamemode.character
{

    public class AdminCMDS :Script
    {
        public AdminCMDS()
        {

        }

        [Command("cc")]
        public void CmdCreateCar(Client client, string type)
        {
            if (client.GetData("ADMIN") > 0)
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
            client.Position = pos;
        }


    }
}