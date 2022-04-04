using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

// Created by Caleb

public class GameManager : MonoBehaviour {



private static GameObject player1, player2; //The playerObjects to be set and called later
public static GameObject PlayerMoney1, PlayerMoney2;


public static GameManager instance; //Create instance to call to all other functions EASILY // These are the players for the game, WILL add more if we want more


    //Serializabe Allows other classes to read this function when called

    [System.Serializable]
    public class Entity 
    {

        public string playerName; //Playersname for database
        public bool hasTurn;    //check whether player Has turn for jail function later
        public enum PlayerTypes //Create a function for whether we will add CPU later

     {
            HUMAN,
           // CPU

           //We could add CPU???

           //In retrospect, while being at the end of the module, CPU could be a thing to add outside of Uni work on a later date
     }
        public PlayerTypes playerType; //Adds playertype Human or other
        public bool hasWon; //Bool for whether player has one, to be implemented later

    }

    
    void Awake()
    {
        instance = this;
    }

 //------------------------------------------------Dice Roll--------------------------------//

    public static void MovePlayer(int playerToMove)
    {

        
        player1 = GameObject.Find("Player(Clone)");
        player2 = GameObject.Find("Player2(Clone)");

       player1.GetComponent<Player>().moveAllowed = false;
       player2.GetComponent<Player2>().moveAllowed = false;
        

        switch (playerToMove) {

            case 1:
               player1.GetComponent<Player>().moveAllowed = true; 
                break;
            
            case 2:
                player2.GetComponent<Player2>().moveAllowed = true;
                break;
        }
    }

}
