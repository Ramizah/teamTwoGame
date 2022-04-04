using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using Photon.Realtime;

// Created by Caleb

public class Player : MonoBehaviour

{

    //All code Same context to Player2 code, Check Player2 code for explanation


public static Vector3 FinalPos;
private static GameObject player1;

public static Player instance;

public int FirstDice; 
public int SecondDice;
public int PassableFirstDice;
public int PassableSecondDice;
int routePosition; 

public bool moveAllowed;
protected static bool isMoving;

    void Awake()
    {
        instance = this;
    }


    public void Start()
    {
        moveAllowed = false;
        FirstDice = 0;
        SecondDice = 0;
    }

    [PunRPC]
   public void Update() {

       Debug.Log(FirstDice);
       Debug.Log(SecondDice);

       if(!isMoving && moveAllowed) 
       {
           FirstDice = Random.Range(1, 7);
           SecondDice = Random.Range(1, 7);

           PassableFirstDice = FirstDice - 1;
            PassableSecondDice = SecondDice - 1;

             DiceRoll1.instance.CallFirstRoll(PassableFirstDice);
             DiceRoll2.instance.CallSecondRoll(PassableSecondDice);

           Debug.Log("First Dice Rolled " + FirstDice);
           Debug.Log("Second Dice Rolled " + SecondDice);
           InfoDice.instance.Rolling("You rolled! " + (FirstDice + SecondDice));

           StartCoroutine(MovePlayer1());

       }

   }


   IEnumerator MovePlayer1() 

   {
       
       if(isMoving) 
       {
            yield break;
       }


       isMoving = true;
   


   while(SecondDice> 0) 
    {

         routePosition++;
         routePosition %= FindObjectOfType<Route>().nodeElements.Count;

         Vector3 nextPos = FindObjectOfType<Route>().nodeElements[routePosition].position;


         while(MoveToNextNode1(nextPos))
         {
             yield return null;
       
         }


        yield return new WaitForSeconds(0.1f);



        SecondDice--;
    }



    while(FirstDice> 0) 
    {


         routePosition++;
         routePosition %= FindObjectOfType<Route>().nodeElements.Count;

         Vector3 nextPos = FindObjectOfType<Route>().nodeElements[routePosition].position;
         while(MoveToNextNode1(nextPos))
         {
             yield return null;
       
         }

        yield return new WaitForSeconds(0.1f);
        FirstDice--;

    }

        FinalPos = FindObjectOfType<Route>().nodeElements[routePosition].position;
        Debug.Log(FinalPos);
    
        PhotonView pView = GetComponent<PhotonView>();
        pView.RPC("SendPosition", RpcTarget.OthersBuffered, FinalPos);
        EndState();

}

public void EndState()
{
        isMoving = false;
        moveAllowed = false;
}

[PunRPC]
 public void SendPosition(Vector3 a)
   {
       player1 = GameObject.Find("Player(Clone)");
       player1.transform.position = a;
       Debug.Log(a);
   }



bool MoveToNextNode1(Vector3 goal) 
{



    return goal != (transform.position = Vector3.MoveTowards(transform.position, goal, 4f * Time.deltaTime));

}

}

