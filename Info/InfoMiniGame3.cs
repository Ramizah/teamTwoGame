using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// Created by Caleb

//-----------------------------------------------------------INFO CODE SHOULD GO IN INFO FOLDER----------------------------------------------------------------------------//

public class InfoMiniGame3 : MonoBehaviour
{
    public static InfoMiniGame3 instance; // Sets instance to be referenced later on in other Classes
    public Text WinText; // Text for P1 money

    //Same as in Info

    void Awake() 
    {
        instance = this;
        WinText.text = "";
    }

    //Same as in Info

    public void WinInfo(string Text)
    {
        WinText.text = Text;
    }
}