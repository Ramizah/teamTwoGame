using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// Created by Caleb

//-----------------------------------------------------------INFO CODE SHOULD GO IN INFO FOLDER----------------------------------------------------------------------------//

public class InfoTrade2 : MonoBehaviour
{

    public static InfoTrade2 instance;
    public Text Info;
    
    void Awake() 
    {
        instance = this;
        Info.text = "";
    }

    public void TradeText(string Text)
    {
        Info.text = Text;
    }
}
