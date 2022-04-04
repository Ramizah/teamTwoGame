using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

// Created by Caleb

//similar to script 1 but for Player 2's trigger and win condition

public class WinState2 : MonoBehaviour
{
    public GameObject MainCamera;
    public static WinState2 instance;
    public GameObject MiniGame2;
    public GameObject AnnoyingCanvas;
    private GameObject CameraController;
    public MoneySystem Money;
    PhotonView Change;

    void Awake()
    {
       instance = this; 
    }

    public void DisableTriggerForOther()
    {
        GetComponent<Collider2D>().isTrigger = false;
    }

    public void EnableTriggerForOther()
    {
        GetComponent<Collider2D>().isTrigger = true;
    }

    void Start()
    {
        Money = FindObjectOfType<MoneySystem>();
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        GetComponent<Collider2D>().isTrigger = false;
        Change = GetComponent<PhotonView>();
        Change.RPC("ChangeRPC", RpcTarget.All);
    }

    [PunRPC]
    void ChangeRPC()
    {
        GetComponent<Collider2D>().isTrigger = false;
        WinState1.instance.DisableTriggerForOther();
        StartCoroutine("Winner");
    }

    public IEnumerator Winner()
    {
        Money.moneyPlay2 += 200;
        InfoMiniGame2.instance.P1Info("Player 2 has won 200 points!");

        GameObject[] Players = GameObject.FindGameObjectsWithTag("Player");

        yield return new WaitForSeconds(3f);
        CameraController = GameObject.Find("MiniGameCamera2");
        CameraController.GetComponent<CameraController>().awake = false;
        foreach(GameObject play in Players)
        {
            Destroy(play);
        }
        InfoMiniGame2.instance.P1Info("");
        MainCamera.SetActive(true);
        AnnoyingCanvas.SetActive(false);
        MiniGame2.SetActive(false);
        GetComponent<Collider2D>().isTrigger = true;
        WinState1.instance.EnableTriggerForOther();
    }
}