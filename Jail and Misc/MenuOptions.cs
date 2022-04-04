using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Photon.Pun;

// Created by Caleb

public class MenuOptions : MonoBehaviour
{
    public AudioManager Audio;

    //Might have to keep audio play on start as audio cuts off due to scene change :(

    void Start()
    {
        Audio = FindObjectOfType<AudioManager>();
        Audio.Play("Press");
    }
    public void playGame()
    {
        SceneManager.LoadScene("Login&SignUp");
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("GameMenu");
    }

    public void Lobby()
    {
        SceneManager.LoadScene("Lobby");
    }

    public void LobbyToMenu()
    {
        StartCoroutine("Disconnect");
        SceneManager.LoadScene("GameMenu");
    }

    //Make menu buttons after connection call disconnect or the player will still be on Photon Gameserver

    public IEnumerator Disconnect()
    {
        PhotonNetwork.Disconnect();
        while(PhotonNetwork.IsConnected)
        {
        yield return null;
        Debug.Log("Disconnecting...");
        }
        Debug.Log("Disconnected!");
    }

    public void Credits()
    {
        SceneManager.LoadScene("Credits");
    }

    public void HowToPage1()
    {
        SceneManager.LoadScene("HowToPlay1");
    }

    public void HowToPage2()
    {
        SceneManager.LoadScene("HowToPlay2");
    }

    public void HowToPage3()
    {
        SceneManager.LoadScene("HowToPlay3");
    }

    public void HowToPage4()
    {
        SceneManager.LoadScene("HowToPlay4");
    }

    public void HowToPage5()
    {
        SceneManager.LoadScene("HowToPlay5");
    }

    public void HowToPage6()
    {
        SceneManager.LoadScene("HowToPlay6");
    }

    public void HowToPage7()
    {
        SceneManager.LoadScene("HowToPlay7");
    }

}
