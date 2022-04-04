using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using UnityEngine.SceneManagement;
using UnityEngine.Networking;
using System;

public class ConnectToServer : MonoBehaviourPunCallbacks
{

    public int FirstTime = 0;

    public AudioManagerNetwork Audio;

    //User settings and connect to server, Joins scene Lobby
    private void Start()
    {
        Audio = FindObjectOfType<AudioManagerNetwork>();
        Audio.Play("MiniGame");
        StartCoroutine(CheckInter(IsConnected =>
    {

      if(IsConnected)
      {
        Debug.Log("You are connected to the Internet");
        PhotonNetwork.ConnectUsingSettings();
      }
      if(!IsConnected)
      {
        Debug.Log("You have no internet connection!");
        Start();
      }

    }));
    }


    

    public IEnumerator CheckInter(Action<bool> action)
{
        if(FirstTime == 0)
        {
            yield return new WaitForSeconds(0.1f);
            FirstTime = 1;

        UnityWebRequest request = new UnityWebRequest("https://www.google.com/");
        yield return request.SendWebRequest();

      if(request.error != null)
      {
        action (false);
      }
      else
      {
        action (true);
      }
        }


        if(FirstTime == 1)
        {
            yield return new WaitForSeconds(15);

      UnityWebRequest request = new UnityWebRequest("https://www.google.com/");
      yield return request.SendWebRequest();

      if(request.error != null)
      {
        action (false);
      }
      else
      {
        action (true);
      }

    }
}




    public override void OnConnectedToMaster()
    {
        PhotonNetwork.JoinLobby();
        Debug.Log("Connected to Master");
    }


    public override void OnJoinedLobby() 
    {
        SceneManager.LoadScene("CharacterSelection");
        
    }


    
}

