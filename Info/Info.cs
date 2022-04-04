using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// Created by Caleb

//-----------------------------------------------------------INFO CODE SHOULD GO IN INFO FOLDER----------------------------------------------------------------------------//

public class Info : MonoBehaviour
{
    public static Info instance; // Creates instance to be referenced in other classes
    public Text infoText; // info box 1
    public Text infoText2; // info box 2

    //Sets instance to this file, sets info boxes to have no text

    void Awake() 
    {
        instance = this;
        infoText.text = "";
        infoText.text = "";
    }

    //Shows message based on Strings to be debugged

    public void ShowMessage(string UItext)
    {
        infoText.text = UItext;
    }

    //Shows the turn of the specific player, as seen in Dice class

    public void ShowTurn(string TurnShow)
    {
        infoText2.text = TurnShow;
    }
}
