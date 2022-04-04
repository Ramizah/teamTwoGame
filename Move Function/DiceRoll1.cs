using Photon.Realtime;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using Photon.Pun;

// Created by Caleb


//Variable passed by either Player1 or Player2 Classes will be passed as a variable over through a Singleton. Shows the roll of each player on the 2d dice on the board

//Variables are -1 of the original roll due to the array starting at 0

//Two files are needed for each dice. Though, their is probably a more efficient way to merge the required code into 1 file

//Probably requires calling the SpriteRenderer of both 2d dice externally instead of getting the component off of the gameobject in which the scripts are on

//For a first time attempt at Unity, it works as intended
public class DiceRoll1 : MonoBehaviour
{
    private Sprite[] diceSides;
    private SpriteRenderer UseSprites;
    public static DiceRoll1 instance;

    void Awake()
    {
        instance = this;
    }
    
    void Start()
    {
        UseSprites = GetComponent<SpriteRenderer>();
        diceSides = Resources.LoadAll<Sprite>("DiceSides/"); 


        UseSprites.sprite = diceSides[5]; 
    }

    public void CallFirstRoll(int PassVar)
    {
        StartCoroutine(RollTheDice(PassVar));
    }

    public IEnumerator RollTheDice(int firstDice)
    { 

        int SpirteRandom = 0;


        for (int i = 0; i <= 10; i++)
        {
            SpirteRandom= Random.Range(0,6);
            UseSprites.sprite = diceSides[SpirteRandom];
            yield return new WaitForSeconds(0.1f);
        }
        UseSprites.sprite = diceSides[firstDice];

    }

}
