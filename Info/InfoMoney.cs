using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// Created by Caleb

//-----------------------------------------------------------INFO CODE SHOULD GO IN INFO FOLDER----------------------------------------------------------------------------//

public class InfoMoney : MonoBehaviour
{
    public static InfoMoney instance; // Sets instance to be referenced later on in other Classes
    public Text P1; // Text for P1 money
    public Text P2; // Text for P2 money

    //Same as in Info

    void Awake() 
    {
        instance = this;
        P1.text = "P1: 1500";
        P2.text = "P2: 1500";
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
}
