using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Created by Caleb

//This code checks if camera is awake, if the camera is active then it is set onto the playerprefab that is spawned, otherwise the camera is removed along with the gameobject

public class CameraController : MonoBehaviour
{
    private GameObject playerPrefab;
    public static CameraController instance;
    public bool awake;

    //Create singelton so it can be called to the minigame files, camera not perfect though, (works anyway)

    void Awake()
    {
        instance = this;
    }

    public void ActivateCamera()
    {   
        awake = true;
    }

    //Playerposition called using deterministic label of playfab. Will always be miniPlayerClone

    void Update()
    {
        if(awake == true)
        {
            playerPrefab = GameObject.Find("MiniPlayer(Clone)");
            transform.position = new Vector3(playerPrefab.transform.position.x, playerPrefab.transform.position.y, transform.position.z);
        }
    }





}
