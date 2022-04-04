using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Photon.Pun;

public class CharacterSelect : MonoBehaviour
{
    public GameObject Skin1;
    public GameObject Skin2;
    public GameObject Skin3;
    public GameObject Skin4;
    public GameObject Skin5;
    public GameObject Skin6;

    public AudioManagerNetwork Audio;

    public int P1Choice;
    public int P2Choice;
    public int Count = 1;
    public static int FinalChoice;

    void Start()
    {
        Audio = FindObjectOfType<AudioManagerNetwork>();
        Skin1.SetActive(true);
        Skin2.SetActive(false);
        Skin3.SetActive(false);
        Skin4.SetActive(false);
        Skin5.SetActive(false);
        Skin6.SetActive(false);
        FinalChoice = 1;
    }

    void Update()
    {
        Debug.Log(FinalChoice);
    }

    public void LeftSelect()
    {
        Audio.Play("HowTo");
        Count--;
        if(Count < 1)
        {
            Count = 6;
        }

        if(Count == 1)
        {
        Skin1.SetActive(true);
        Skin2.SetActive(false);
        Skin3.SetActive(false);
        Skin4.SetActive(false);
        Skin5.SetActive(false);
        Skin6.SetActive(false);
        FinalChoice = 1;
        }

        if(Count == 2)
        {
        Skin1.SetActive(false);
        Skin2.SetActive(true);
        Skin3.SetActive(false);
        Skin4.SetActive(false);
        Skin5.SetActive(false);
        Skin6.SetActive(false);
        FinalChoice = 2;
        }
        if(Count == 3)
        {
        Skin1.SetActive(false);
        Skin2.SetActive(false);
        Skin3.SetActive(true);
        Skin4.SetActive(false);
        Skin5.SetActive(false);
        Skin6.SetActive(false);
        FinalChoice = 3;
        }
        if(Count == 4)
        {
        Skin1.SetActive(false);
        Skin2.SetActive(false);
        Skin3.SetActive(false);
        Skin4.SetActive(true);
        Skin5.SetActive(false);
        Skin6.SetActive(false);
        FinalChoice = 4;
        }
        if(Count == 5)
        {
        Skin1.SetActive(false);
        Skin2.SetActive(false);
        Skin3.SetActive(false);
        Skin4.SetActive(false);
        Skin5.SetActive(true);
        Skin6.SetActive(false);
        FinalChoice = 5;
        }
        if(Count == 6)
        {
        Skin1.SetActive(false);
        Skin2.SetActive(false);
        Skin3.SetActive(false);
        Skin4.SetActive(false);
        Skin5.SetActive(false);
        Skin6.SetActive(true);
        FinalChoice = 6;
        }
    }

    public void RightSelect()
    {
        Audio.Play("HowTo");
        Count++;
        if(Count > 6)
        {
            Count = 1;
        }

        if(Count == 1)
        {
        Skin1.SetActive(true);
        Skin2.SetActive(false);
        Skin3.SetActive(false);
        Skin4.SetActive(false);
        Skin5.SetActive(false);
        Skin6.SetActive(false);
        FinalChoice = 1;
        }

        if(Count == 2)
        {
        Skin1.SetActive(false);
        Skin2.SetActive(true);
        Skin3.SetActive(false);
        Skin4.SetActive(false);
        Skin5.SetActive(false);
        Skin6.SetActive(false);
        FinalChoice = 2;
        }
        if(Count == 3)
        {
        Skin1.SetActive(false);
        Skin2.SetActive(false);
        Skin3.SetActive(true);
        Skin4.SetActive(false);
        Skin5.SetActive(false);
        Skin6.SetActive(false);
        FinalChoice = 3;
        }
        if(Count == 4)
        {
        Skin1.SetActive(false);
        Skin2.SetActive(false);
        Skin3.SetActive(false);
        Skin4.SetActive(true);
        Skin5.SetActive(false);
        Skin6.SetActive(false);
        FinalChoice = 4;
        }
        if(Count == 5)
        {
        Skin1.SetActive(false);
        Skin2.SetActive(false);
        Skin3.SetActive(false);
        Skin4.SetActive(false);
        Skin5.SetActive(true);
        Skin6.SetActive(false);
        FinalChoice = 5;
        }
        if(Count == 6)
        {
        Skin1.SetActive(false);
        Skin2.SetActive(false);
        Skin3.SetActive(false);
        Skin4.SetActive(false);
        Skin5.SetActive(false);
        Skin6.SetActive(true);
        FinalChoice = 6;
        }
    }

    public void CharacterSelection()
    {
        Debug.Log(FinalChoice);
        SceneManager.LoadScene("Lobby");
    }
}
