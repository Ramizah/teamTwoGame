using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// Created by Caleb

//-----------------------------------------------------------INFO CODE SHOULD GO IN INFO FOLDER----------------------------------------------------------------------------//

public class InfoMiniGame1 : MonoBehaviour
{
    public static InfoMiniGame1 instance; // Sets instance to be referenced later on in other Classes
    public Text P1; 
    public Text P2;
    public Text Winner;

    //Same as in Info

    void Awake() 
    {
        instance = this;
        P1.text = "Mash Total: ";
        P2.text = "Mash Total: ";
        Winner.text = "";
    }

    //Same as in Info

    public void P1Info(string P1Text)
    {
        P1.text = P1Text;
    }

    public void P2Info(string P2Text)
    {
        P2.text = P2Text;
    }

    public void WinnerInfo(string WinText)
    {
        Winner.text = WinText;
    }
}