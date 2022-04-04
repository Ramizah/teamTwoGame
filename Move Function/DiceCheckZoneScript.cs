using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//Unused Script

public class DiceCheckZoneScript : MonoBehaviour
{
    Vector3 diceVelocity;
    public static int diceNumber = 0;

    void FixedUpdate()
    {
        diceVelocity = PhysicalDiceRolling.diceVelocity;
    }

    void OnTriggerStay(Collider  col)
    {
        if(diceVelocity.x == 0f && diceVelocity.y == 0f && diceVelocity.z == 0f)
        {
            switch (col.gameObject.name)
            {
                case "side1":
                    diceNumber = 6;
                    break;
                case "Side2":
                    diceNumber = 5;
                    break;
                case "Side3":
                    diceNumber = 4;
                    break;
                case "Side4":
                    diceNumber = 3;
                    break;
                case "Side5":
                    diceNumber = 2;
                    break;
                case "Side6":
                    diceNumber = 1;
                    break;
            }
        }
    }
}
