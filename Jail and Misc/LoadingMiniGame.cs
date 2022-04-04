using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using Photon.Pun;

// Created by Caleb

public class LoadingMiniGame : MonoBehaviour
{


    public MiniGame1 Game1;
    public MiniGame2 Game2;
    public MiniGame3 Game3;
    public AudioManager Audio;

    public GameObject MainCamera;
    public GameObject LoadingCamera;
    public GameObject MiniGame1Img;
    public GameObject MiniGame3Img;
    public GameObject MiniGame2Img1;
    public GameObject MiniGame2Img2;
    public GameObject MiniGame1Text;
    public GameObject MiniGame2Text;
    public GameObject MiniGame3Text;

    public int Countdown;
    public Text CountDownText;

    public bool FirstMiniGame1 = true;

    //ALL miniGAMES SHOULD CALL THIS FILE

    public void Start()
    {
        MainCamera.SetActive(true);
        LoadingCamera.SetActive(false);
        MiniGame1Img.SetActive(false);
        MiniGame1Text.SetActive(false);
        MiniGame2Img1.SetActive(false);
        MiniGame2Img2.SetActive(false);
        MiniGame2Text.SetActive(false);
        MiniGame3Img.SetActive(false);
        MiniGame3Text.SetActive(false);
        Game1 = FindObjectOfType<MiniGame1>();
        Game2 = FindObjectOfType<MiniGame2>();
        Game3 = FindObjectOfType<MiniGame3>();
        Audio = FindObjectOfType<AudioManager>();
    }

    //Might delay other games not sure

    public void Starting(int GameToStart)
    {
        PhotonView Count = GetComponent<PhotonView>();

        LoadGameRPC(GameToStart);
        Count.RPC("LoadGameRPC", RpcTarget.Others, GameToStart);

        StartCoroutine(StartMini(GameToStart));
    }

    [PunRPC]
    public void LoadGameRPC(int MiniGame)
    {
        Audio.Play("MiniGame");
        MainCamera.SetActive(false);
        LoadingCamera.SetActive(true);

        if(MiniGame == 1)
        {
            MiniGame1Img.SetActive(true);
            MiniGame1Text.SetActive(true);
        }
        
        if(MiniGame == 2)
        {
            MiniGame2Img1.SetActive(true);
            MiniGame2Img2.SetActive(true);
            MiniGame2Text.SetActive(true);
        }

        if(MiniGame == 3)
        {
            MiniGame3Img.SetActive(true);
            MiniGame3Text.SetActive(true);
        }

        StartCoroutine(CountdownFunction());
    }

    public IEnumerator CountdownFunction()
    {
        while(Countdown > 0)
        {
            CountDownText.text = Countdown.ToString();

            yield return new WaitForSeconds(1f);

            Countdown--;
        }
    }

    //WaitForSeconds 5.5 might be too long for player 2, might have to check this (out of sync minigames).

    public IEnumerator StartMini(int MiniGame)
    {
        PhotonView Count = GetComponent<PhotonView>();
        yield return new WaitForSeconds(5.5f);

        if(MiniGame == 1)
        {
            Game1.STARTGAME();
        }
        
        if(MiniGame == 2)
        {
            Game2.STARTGAME();
        }

        if(MiniGame == 3)
        {
            Game3.STARTGAME();
        }

        Count.RPC("ResetCount", RpcTarget.All);
    }

    [PunRPC]
    public void ResetCount()
    {
        Countdown = 5;
        MiniGame1Img.SetActive(false);
        MiniGame1Text.SetActive(false);
        MiniGame2Img1.SetActive(false);
        MiniGame2Img2.SetActive(false);
        MiniGame2Text.SetActive(false);
        MiniGame3Img.SetActive(false);
        MiniGame3Text.SetActive(false);
    }

}
