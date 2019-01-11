using System;
using GTANetworkAPI;
using MyCustomGamemode.database;
using MyCustomGamemode.character;
using MyCustomGamemode.globals;
using MyCustomGamemode.jobs;
namespace MyCustomGamemode.chat
{


public class Chat 
{
	public Chat()
	{
	}
    [RemoteEvent("OnPlayerChatMessage")]
    public void OnPlayerChat(Client client,string value)
        {
            client.SendChatMessage(value);
        }

}

}