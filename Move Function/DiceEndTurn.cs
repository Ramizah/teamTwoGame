using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Photon.Pun;

// Created by Caleb

public class DiceEndTurn : Dice //extends Dice, so has all its variables and stuff
{
    //[PunRPC] for RPC call and EndTurn to switch Count 

    [PunRPC]
    public void EndTurn()
    {
        Audio.Play("End");
        Count++;
        Count %= 2;
    }

    //This is called if button End Turn is clicked. Deactivated until next turn for specific player

    public void CallThis1()
    {
        if(CheckOtherRoll)
        {
            StartCoroutine(DelayTurn());
            CheckOtherRoll = false;
        }
        
    }

    public void CallThis2()
    {
        if(CheckOtherRoll)
        {
            StartCoroutine(DelayTurn());
            CheckOtherRoll = false;
        }
        
    }

    //Ends turn, changes player and sends message to UI that player has changed. Then sets the ENDTURN buttons to be invisible

    public IEnumerator DelayTurn()
    {
            EndTurn();

            Info.instance.ShowMessage("Player Ended Turn!");

            yield return new WaitForSeconds(2);

            coroutineAllowed = true;
            
            RPC();
            Audio.Play("End");

            yield return new WaitForSeconds(2);

            EndTurn1.SetActive(false);

            EndTurn2.SetActive(false);
            
            CheckOtherRoll = true;
    }


    public void RPC()
    {
        Debug.Log("Why only Player 1??!?!?!?!");
        PhotonView pView = GetComponent<PhotonView>();

        pView.RPC("EndTurn", RpcTarget.OthersBuffered);
    }

}
