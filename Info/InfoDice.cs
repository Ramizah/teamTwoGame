using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// Created by Caleb

//-----------------------------------------------------------INFO CODE SHOULD GO IN INFO FOLDER----------------------------------------------------------------------------//

public class InfoDice : MonoBehaviour
{
    public static InfoDice instance; 
    public Text Dice; 

    //Same as in Info

    void Awake() 
    {
        instance = this;
        Dice.text = "Roll!";
    }

    //Same as in Info

    public void Rolling(string RollText)
    {
        Dice.text = RollText;
    }

}
