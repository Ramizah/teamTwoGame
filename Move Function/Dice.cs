using Photon.Realtime;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using Photon.Pun;

// Created by Caleb

public class Dice : MonoBehaviour
{

    //------------------------------------------------------AROON THIS FILE IS PROBABLY THE ONE YOU WANT TO WORK ON---------------------------------------------------//

public GameObject EndTurn1; //The gameObject of player 1 end turn button
public GameObject EndTurn2; //The gameObject of player 2 end turn button
private static GameObject player1, player2; //GameObjects of the playerPrebs 1 and 2 //Number of dice sides : TO BE REMOVED AROON //rend sprites : TO BE REMOVED AROON
public SpawnPlayer ID;
public AudioManager Audio;

//Roll

public bool IsTurn; // Checks whether its currrent players turn
public static int Count; //Count that increments based on player turn


public static bool coroutineAllowed; // checks whether button is clickable or not
public bool CheckOtherRoll;


// START FUNCTION SETS THE ENDTURN BUTTONS TO NOT SHOW INGAME AT START

public void Start()
{
    CheckOtherRoll = true;
    Count = 0;
    IsTurn = false;
    coroutineAllowed = true;
    EndTurn1.SetActive(false);
    EndTurn2.SetActive(false);
    ID = FindObjectOfType<SpawnPlayer>();
    AnnoyingBug();
}

public void AnnoyingBug()
{
    if(ID.ConstantID == 0)
    {
        EndTurn1.SetActive(true);
    }
}

//UPDATE LOOP CONSTANTLY CHECKS WHICH PLAYER'S TURN IT IS BASED ON PLAYER ID AND TURN INCREMENTATION COUNTER

public void Update()
{

    if(ID.ConstantID == 0 && Count == 0)
    {
        Info.instance.ShowTurn("P1 Turn");
        IsTurn = true;
    }
    
    if(ID.ConstantID == 1 && Count == 0)
    {
        Info.instance.ShowTurn("P1 Turn");
        IsTurn = false;
    }

    if(ID.ConstantID == 0 && Count == 1)
    {
        Info.instance.ShowTurn("P2 Turn");
        IsTurn = false;
    }

    if(ID.ConstantID == 1 && Count == 1)
    {
        Info.instance.ShowTurn("P2 Turn");
        IsTurn = true;
    }
}

//SETS UP 2D DICE ROLL BEFORE ACTUAL PHYSICAL CODE ROLE

public void SetupRoll() 
{ 
       StartCoroutine("CheckPlayer");
}

//-------------------------------------------!IMPORTANT! Then call "CheckPlayer", activating roll !IMPORTANT! ---------------------------------------//

    //CheckPlayer sends code to GameManger Switch depending on which Player it is and sets End Turn button to show, so player can end turn

        public IEnumerator CheckPlayer()
        {
    
            if (ID.ConstantID == 0)
        {
          GameManager.MovePlayer(1);
          yield return new WaitForSeconds(4.5f);
          EndTurn1.SetActive(true); 
        }
    

        else if (ID.ConstantID == 1)
        {
            GameManager.MovePlayer(2);
            yield return new WaitForSeconds(4.5f);
            EndTurn2.SetActive(true);
        }
        


        yield return new WaitForSeconds(2);

        
        }

}