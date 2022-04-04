using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// Created by Caleb

//-----------------------------------------------------------INFO CODE SHOULD GO IN INFO FOLDER----------------------------------------------------------------------------//

public class InfoProperty2 : MonoBehaviour
{
    public static InfoProperty2 instance; 
    public Text Street; 
    public Text Price;
    public Text Set; 



    void Awake() 
    {
        instance = this;
        Street.text = "";
        Price.text = "";
        Set.text = "";
    }



    public void StreetInfo(string StreetText)
    {
        Street.text = StreetText;
    }

    public void PriceInfo(string PriceText)
    {
        Price.text = PriceText;
    }

    public void SetInfo(string SetText)
    {
        Set.text = SetText;
    }
}

