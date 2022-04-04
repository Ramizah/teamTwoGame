using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using Photon.Realtime;

public class GetUserID : MonoBehaviour
{

    //Does same thing as SpawnPlayer, gets user Id WHICH IS INhereted by Dice

    Player[] allPlayers;
    public int myNumberInRoom;
    //public bool Player1 = false;
    //public bool Player2 = false;

        //Get room number:
        //1. Set allPlayers Players[] to the PhotonNetwork.PlayerList of the room

        //2. For each of the players of playerlist p, do if statement

        //3. If player is not the local player, +1 ID untill it is them

        //4.That is the users ID

        //Set Spawn of player and debug the player name based on the room ID

    void Start()
    {
         allPlayers = PhotonNetwork.PlayerList;

        foreach(Player p in allPlayers)
        {

            if(p!= PhotonNetwork.LocalPlayer)
            {
                myNumberInRoom++;
            }

            Debug.Log(myNumberInRoom);

        }
    }


}
