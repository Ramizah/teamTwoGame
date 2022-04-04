using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// Created by Caleb

//-----------------------------------------------------------INFO CODE SHOULD GO IN INFO FOLDER----------------------------------------------------------------------------//

public class InfoMiniGame2 : MonoBehaviour
{
    public static InfoMiniGame2 instance; // Sets instance to be referenced later on in other Classes
    public Text P1; // Text for P1 money

    //Same as in Info

    void Awake() 
    {
        instance = this;
        P1.text = "";
    }

    //Same as in Info

    public void P1Info(string P1Text)
    {
        P1.text = P1Text;
    }
}
