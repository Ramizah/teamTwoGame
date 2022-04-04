using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

//Created by Caleb

//Similar to the other minigames, activates canvas of minigame 3 from loading, sets a random time for buttons to appear while activating a fail trigger for pressing early

//Once activated however, the faster player when pressing their button determines the winner while disabling the other player's button who was slower

//Like the other Minigames, RPC's 200

public class MiniGame3 : MonoBehaviour
{
    public SpawnPlayer ID;
    public MoneySystem Money;

    public GameObject MainCamera;
    public GameObject Game3Camera;
    public GameObject AnnoyingCanvas;

    public GameObject P1ReactUI;
    public GameObject P2ReactUI;
    public GameObject P1ReactButton;
    public GameObject P2ReactButton;

    public int RandomWait;
    public int Money1;
    public int Money2;
    public bool DontPress;
    public int Count;
    
    PhotonView React;

    void Update()
    {
        if(ID.ConstantID == 0 && DontPress == true && Input.GetMouseButton(0))
        {
            if(Count == 1)
            {
                P2WinError();
                Count = 0;
            }
        }
        if(ID.ConstantID == 1 && DontPress == true && Input.GetMouseButton(0))
        {
            if(Count == 1)
            {
                P1WinError();
                Count = 0;
            }
        }
    }

    public void P1WinError()
    {
        React.RPC("P1WinRPC", RpcTarget.All);
    }

    public void P2WinError()
    {
        React.RPC("P2WinRPC", RpcTarget.All);
    }

    void Start()
    {
        Count = 1;
        DontPress = false;
        P1ReactUI.SetActive(false); P2ReactUI.SetActive(false); P1ReactButton.SetActive(false); P2ReactButton.SetActive(false);
        MainCamera.SetActive(true);
        Game3Camera.SetActive(false);
        AnnoyingCanvas.SetActive(false);
        React = GetComponent<PhotonView>();
        ID = FindObjectOfType<SpawnPlayer>();
        Money = FindObjectOfType<MoneySystem>();
    }

    public void STARTGAME()
    {
        RandomWait = Random.Range(4,12);
        React.RPC("StartGameRPC", RpcTarget.All, RandomWait);
    }

    [PunRPC]
    public void StartGameRPC(int PassWait)
    {
        MainCamera.SetActive(false);
        Game3Camera.SetActive(true);
        AnnoyingCanvas.SetActive(true);
        StartCoroutine(BeginReaction(PassWait));
    }

    public IEnumerator BeginReaction(int Wait)
    {
        DontPress = true;
        Debug.Log(Wait);
        yield return new WaitForSeconds(Wait);

        DontPress = false;
        P1ReactUI.SetActive(true); P2ReactUI.SetActive(true); P1ReactButton.SetActive(true); P2ReactButton.SetActive(true);

    }

    public void P1Win()
    {
        if(ID.ConstantID == 0)
        {
            React.RPC("P1WinRPC", RpcTarget.All);
        }
    }

    [PunRPC]
    public void P1WinRPC()
    {
        InfoMiniGame3.instance.WinInfo("P1 Has the faster reactions!! Wins 200");
        P1ReactUI.SetActive(false); P2ReactUI.SetActive(false); P1ReactButton.SetActive(false); P2ReactButton.SetActive(false);
        Count = 1;
        StartCoroutine("CoroutineWait1");
    }

    public IEnumerator CoroutineWait1()
    {
        yield return new WaitForSeconds(3);
        Money1 = 0;
        Money2 = 0;
        Money.moneyPlay1 += 200;
        InfoMiniGame3.instance.WinInfo("");
        MainCamera.SetActive(true);
        Game3Camera.SetActive(false);
        AnnoyingCanvas.SetActive(false);
    }


    public void P2Win()
    {
        if(ID.ConstantID == 1)
        {
            React.RPC("P2WinRPC", RpcTarget.All);
        }
    }

    [PunRPC]
    public void P2WinRPC()
    {
        InfoMiniGame3.instance.WinInfo("P2 Has the faster reactions!! Wins 200");
        P1ReactUI.SetActive(false); P2ReactUI.SetActive(false); P1ReactButton.SetActive(false); P2ReactButton.SetActive(false);
        Count = 1;
        StartCoroutine("CoroutineWait2");
    }

    public IEnumerator CoroutineWait2()
    {
        yield return new WaitForSeconds(3);
        Money1 = 0;
        Money2 = 0;
        Money.moneyPlay2 += 200;
        InfoMiniGame3.instance.WinInfo("");
        MainCamera.SetActive(true);
        Game3Camera.SetActive(false);
        AnnoyingCanvas.SetActive(false);
    }

}
