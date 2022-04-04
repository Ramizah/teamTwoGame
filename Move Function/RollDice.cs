using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Created by Caleb

//Called when roll is clicked, checks whether both players have logged on

public class RollDice : Dice
{

    private static GameObject DiceFunction;
    private static GameObject player1, player2;

    public void StartRoll() 
{

    player1 = GameObject.Find("Player(Clone)");

    if(player1 == null)
    {
        Info.instance.ShowMessage("P1 has not connected yet!");
        return;
    }

    player2 = GameObject.Find("Player2(Clone)");

    if(player2 == null)
    {
        Info.instance.ShowMessage("P2 has not connected yet!");
        return;
    }
//IF PLAYER IS ACTIVE THEN ROLL, IF NOT DO NOT ROLL

    if(coroutineAllowed == true & IsTurn == true)
    {
        Audio.Play("Dice");
        DiceFunction = GameObject.Find("Dice");
        DiceFunction.GetComponent<Dice>().SetupRoll();
        coroutineAllowed = false;
    }
}

}
