using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

// Created by Caleb

public class EndGame : MonoBehaviour
{

    //Call leaderboard here 

    public SpawnPlayer Spawn;

    public int Win = 1;

    void Start()
    {
        Spawn = FindObjectOfType<SpawnPlayer>();
    }

    //Using Player ID to check whos RPC'd to which scene

    //Should call to GameScene ENDP1

    public void GameOverP1()
    {
        if(Spawn.ConstantID == 0)
        {
            Debug.Log("You Lose");
        }
        if(Spawn.ConstantID == 1)
        {
            UserAccountManager.instance.SendLeaderboard(Win);
        }
        SceneManager.LoadScene("EndP1");
    }

    //Should call to GameScene ENDP2

    public void GameOverP2()
    {
        if(Spawn.ConstantID == 0)
        {
            UserAccountManager.instance.SendLeaderboard(Win);
        }
        if(Spawn.ConstantID == 1)
        {
            Debug.Log("Ooof!");
        }
        SceneManager.LoadScene("EndP2");
    }
}
