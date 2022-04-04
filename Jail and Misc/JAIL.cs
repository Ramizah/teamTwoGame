using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

// Created by Caleb

public class JAIL : MonoBehaviour

//make sure all variables are set in Start or game cannot be reset after new game starts!!

{
    public GameObject jail;
    public GameObject UI;
    public GameObject EndTurn;
    public GameObject Dice;
    public MoneySystem money;
    public SpawnPlayer ID;
    public AudioManager Audio;

    public bool Buy;
    public bool Roll;

    public int roll1;
    public int roll2;


    void Start()
    {
        Buy = false;
        Roll = false;
        jail.SetActive(false);
        UI.SetActive(false);
        money = FindObjectOfType<MoneySystem>();
        ID = FindObjectOfType<SpawnPlayer>();
        Audio = FindObjectOfType<AudioManager>();
    }

    public void LandOnJail()
    {
        jail.SetActive(true);
    }

// Jail button maybe too big, works fine for now

// Audio plays in jail


public void JailButton()
{

    Audio.Play("Press");

    PhotonView JailRPC = GetComponent<PhotonView>();
    UI.SetActive(true);

    if(ID.ConstantID == 0 && Dice.GetComponent<Dice>().IsTurn == true)
    {
        Debug.Log("Clickable1?");
            if(Roll == true)
        {
            roll1 = Random.Range(1, 7);
            roll2 = Random.Range(1, 7);

            if(roll1 == roll2)
            {
                Audio.Play("Escape");
                jail.SetActive(false);
                InfoDice.instance.Rolling("You Got a double, Out of jail!");
            }
            if(roll1 != roll2)
            {
                Audio.Play("Loss");
                Audio.Play("Fail");
                JailRPC.RPC("LoseJailRPC1", RpcTarget.All);
                InfoDice.instance.Rolling("You failed....");
            }
            Roll = false;
            UI.SetActive(false);
        }

        if(Buy == true)
        {
            PayOut1();
            Audio.Play("Escape");
            JailRPC.RPC("PayOut1", RpcTarget.Others);
            jail.SetActive(false);
            UI.SetActive(false);
            Buy = false;
        }

        EndTurn.GetComponent<DiceEndTurn>().EndTurn1.SetActive(true);
    }



    if(ID.ConstantID == 1 && Dice.GetComponent<Dice>().IsTurn == true)
    {
         Debug.Log("Clickable1?");
            if(Roll == true)
        {
            roll1 = Random.Range(1, 7);
            roll2 = Random.Range(1, 7);

            if(roll1 == roll2)
            {
                Audio.Play("Escape");
                jail.SetActive(false);
                InfoDice.instance.Rolling("You Got a double, Out of jail!");
            }
            if(roll1 != roll2)
            {
                Audio.Play("Loss");
                Audio.Play("Fail");
                JailRPC.RPC("LoseJailRPC2", RpcTarget.All);
                InfoDice.instance.Rolling("You Failed......");
            }
            Roll = false;
            UI.SetActive(false);
        }

        if(Buy == true)
        {
            PayOut2();
            Audio.Play("Escape");
            JailRPC.RPC("PayOut2", RpcTarget.Others);
            jail.SetActive(false);
            UI.SetActive(false);
            Buy = false;
        }

         EndTurn.GetComponent<DiceEndTurn>().EndTurn2.SetActive(true);
    }
        

}

//NEED RPC too send jail update to other player, or roll will not function

    [PunRPC]
    public void PayOut1()
    {
        if(ID.ConstantID == 0)
        {
            money.moneyPlay1 -= 200;
            InfoMoney.instance.P1Info("P1: " + money.moneyPlay1);
        }

        if(ID.ConstantID == 1)
        {
            money.moneyPlay1 -= 200;
            InfoMoney.instance.P1Info("P1: " + money.moneyPlay1);
        }
    }

    [PunRPC]
    public void PayOut2()
    {
        if(ID.ConstantID == 0)
        {
            money.moneyPlay2 -= 200;
            InfoMoney.instance.P2Info("P2: " + money.moneyPlay2);
        }

        if(ID.ConstantID == 1)
        {
            money.moneyPlay2 -= 200;
            InfoMoney.instance.P2Info("P2: " + money.moneyPlay2);
        }
    }


    public void WantsToRoll()
    {
        Roll = true;
        JailButton();
    }

    public void WantsToBuy()
    {
        Buy = true;
        JailButton();
    }


//Minus 75 because dice roll number implementation seems too complicated for the game

    [PunRPC]
    public void LoseJailRPC1()
    {
        money.moneyPlay1 -= 75;
    }

    [PunRPC]
    public void LoseJailRPC2()
    {
        money.moneyPlay2 -= 75;
    }
}
