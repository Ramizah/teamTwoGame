using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using Photon.Pun;

// Created by Caleb

//This is the file for the second minigame

//From Loading screen, the canvas for Minigame2 is activated and a playerprefab is spawned along with their designated cameras for play. 

//When the triggers on the flag are hit, the game ends and 200 is RPC'd to the winner

public class MiniGame2 : MonoBehaviour
{
    public GameObject MainCamera;
    public GameObject Game2Camera;
    public GameObject PlayerPrefab;
    public GameObject AnnoyingCanvas;
    public SpawnPlayer ID;

    public float minX;
    public float maxX;
    public float MinY;
    public float MaxY;

    public static MiniGame2 instance;

    void Awake()
    {
        instance = this;
    }

    void Start()
    {
        MainCamera.SetActive(true);
        AnnoyingCanvas.SetActive(false);
        Game2Camera.SetActive(false);
        ID = FindObjectOfType<SpawnPlayer>();
    }

    //Once again, startgame called from Playermoney 1 or 2 might cause delays

    public void STARTGAME()
    {
        PhotonView Mini2 = GetComponent<PhotonView>();
        Mini2.RPC("STARTGAMERPC", RpcTarget.All);
    }

    //Annoying canvas also present for Minigame 2, disable when game is not active

    [PunRPC]
    public void STARTGAMERPC()
    {
        MainCamera.SetActive(false);
        AnnoyingCanvas.SetActive(true);
        Game2Camera.SetActive(true);
        Vector2 Position1 = new Vector2(-24.98f, -3.5f);
        Vector2 Position2 = new Vector2(-15.49f, -3.5f);

        if(ID.ConstantID == 0)
        {
            PhotonNetwork.Instantiate(PlayerPrefab.name, Position1, Quaternion.identity);
        }

        if(ID.ConstantID == 1)
        {
            PhotonNetwork.Instantiate(PlayerPrefab.name, Position2, Quaternion.identity);
        }

        CameraController.instance.ActivateCamera(); 
    }
}
