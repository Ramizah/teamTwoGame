using Photon.Realtime;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using Photon.Pun;

// Created by Caleb

//Same process as explained in DiceRoll1

public class DiceRoll2 : MonoBehaviour
{
    private Sprite[] diceSides;
    private SpriteRenderer UseSprites;
    public static DiceRoll2 instance;

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

    public void CallSecondRoll(int PassVar)
    {
        StartCoroutine(RollTheDice(PassVar));
    }

    public IEnumerator RollTheDice(int secondDice)
    { 

        int SpirteRandom = 0;


        for (int i = 0; i <= 10; i++)
        {
            SpirteRandom= Random.Range(0,6);
            UseSprites.sprite = diceSides[SpirteRandom];
            yield return new WaitForSeconds(0.1f);
        }
        UseSprites.sprite = diceSides[secondDice];

    }

}