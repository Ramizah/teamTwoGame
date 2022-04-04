using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhysicalDiceRolling : MonoBehaviour
{

    //file not used
    
    static Rigidbody rb;
    public static Vector3 diceVelocity;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        //rb.useGravity = false;
    }

    public void StartPhysicsRoll()
    {
        rb.useGravity = true;
        DiceCheckZoneScript.diceNumber = 0;
        float dirX = Random.Range(0, 500);
        float dirY = Random.Range(0, 500);
        float dirZ = Random.Range(0, 500);
        transform.rotation = Quaternion.identity;
        rb.AddTorque(dirX, dirY, dirZ);
    }
}
