using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using Photon.Pun;

// Created by Caleb

public class MiniGame1 : MonoBehaviour
{

    public SpawnPlayer ID;
    public MoneySystem Money;

    public GameObject MainCamera;
    public GameObject Game1Camera;
    public GameObject AnnoyingCanvas;
    public GameObject Button1;
    public GameObject Button2;

    public int Count1;
    public int Count2;
    public int Countdown;

    public bool P1Win;
    public bool P2Win;

    public Text CountdownText;

    //Canvas interrupting other canvases in Scene Game, might have to disable when minigame is false




    void Start()
    {
        Button1.SetActive(true);
        Button2.SetActive(true);
        P1Win = false;
        P2Win = false;
        Count1 = 0;
        Count2 = 0;
        MainCamera.SetActive(true);
        AnnoyingCanvas.SetActive(false);
        Game1Camera.SetActive(false);
        ID = FindObjectOfType<SpawnPlayer>();
        Money = FindObjectOfType<MoneySystem>();
    }

    public void Update()
    {
        InfoMiniGame1.instance.P1Info("Mash Total: " + Count1);
        InfoMiniGame1.instance.P2Info("Mash Total: " + Count2);
    }

    public void MashP1()
    {
        PhotonView Count = GetComponent<PhotonView>();

        if(ID.ConstantID == 0)
        {
            Count1++;
            Count.RPC("RPCCount1", RpcTarget.Others);
        }
        else
        {
            Debug.Log("Incorrect Button!!");
        }
    }

    //Count implementation for button mash

    [PunRPC]
    public void RPCCount1()
    {
        Count1++;
    }

    [PunRPC]
    public void RPCCount2()
    {
        Count2++;
    }

    public void MashP2()
    {
        PhotonView Count = GetComponent<PhotonView>();

        if(ID.ConstantID == 1)
        {
            Count2++;
            Count.RPC("RPCCount2", RpcTarget.Others);
        }
        else
        {
            Debug.Log("Incorrect Button!!");
        }
    }

    public void STARTGAME()
    {
        PhotonView Count = GetComponent<PhotonView>();
        Count.RPC("StartGameRPC", RpcTarget.All);
    }

    [PunRPC]
    public void StartGameRPC()
    {
        Button1.SetActive(true);
        Button2.SetActive(true);
        MainCamera.SetActive(false);
        AnnoyingCanvas.SetActive(true);
        Game1Camera.SetActive(true);
        StartCoroutine("CountdownFunction");
    }

    public IEnumerator CountdownFunction()
    {
        while(Countdown > 0)
        {
            CountdownText.text = Countdown.ToString();

            yield return new WaitForSeconds(1f);

            Countdown--;
        }

        //sets button to false so it can't be pressed after countdown finishes, Prevents double player win

        if(Count1 > Count2)
        {
            InfoMiniGame1.instance.WinnerInfo("P1 HAS WON 200 POINTS!");
            Button1.SetActive(false);
            Button2.SetActive(false);
            P1Win = true;
        }

        if(Count2 > Count1)
        {
            InfoMiniGame1.instance.WinnerInfo("P2 HAS WON 200 POINTS!");
            Button1.SetActive(false);
            Button2.SetActive(false);
            P2Win = true;
        }
        if(Count1 == Count2)
        {
            InfoMiniGame1.instance.WinnerInfo("Draw!! No Points Awarded");
        }

        yield return new WaitForSeconds(5f);
        
        GameWon();
    }

    //Reset count to 10, 20 seconds may be too long for recurring games

    public void GameWon()
    {
        Count1 = 0;
        Count2 = 0;
        Countdown = 10;
        InfoMiniGame1.instance.WinnerInfo("");


        if(P1Win == true)
        {
            Money.moneyPlay1 += 200;
            P1Win = false;
        }
        if(P2Win == true)
        {
            Money.moneyPlay2 += 200;
            P2Win = false;
        }

        MainCamera.SetActive(true);
        AnnoyingCanvas.SetActive(false);
        Game1Camera.SetActive(false);

    }

}