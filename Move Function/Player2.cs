using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using Photon.Realtime;

// Created by Caleb

public class Player2 : MonoBehaviour

{

   //Vectors, Gameobjects and gamestats
public static Vector3 FinalPos; //FinalPos of the player after Dice Roll
private static GameObject player2; //Allows script to locate GameObject of type player2 when the link is made below

public static Player2 instance;

//INT values
int routePosition; //The routeposition for Dice While loop to be incremented
public int FirstDice; //Int for First dice roll
public int SecondDice; //Int for Second dice roll
public int PassableFirstDice;
public int PassableSecondDice;

//BOOL values
public  bool moveAllowed; //Prevents activation unless designated player has set it to true in GAMEMANAGER
protected bool isMoving; //ismoving is set and changed to prevent reloop of dice roll unintentionally

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

   public void Update() {



       if(!isMoving && moveAllowed) {

           //Code creates random roll and sends roll through file to move player or called from the dice instances for the viewable 2d dice sprites on the board
           FirstDice = Random.Range(1, 7);
           SecondDice = Random.Range(1, 7);

           PassableFirstDice = FirstDice - 1;
            PassableSecondDice = SecondDice - 1;

             DiceRoll1.instance.CallFirstRoll(PassableFirstDice);
             DiceRoll2.instance.CallSecondRoll(PassableSecondDice);

           Debug.Log("First Dice Rolled " + FirstDice);
           Debug.Log("Second Dice Rolled " + SecondDice);
           InfoDice.instance.Rolling("You rolled! " + (FirstDice + SecondDice));

           //FOR OTHER CODES:
           //Coroutines
           //They are good because you can call multiple at a time and they can run in other classes while aactive.

           //Calls MovePlayer1()

           StartCoroutine(MovePlayer1());

       }
   }


   [PunRPC]
   IEnumerator MovePlayer1() 

   {
       
       //if is moving, stop function

       if(isMoving) 
       {
            yield break;
       }

       //set is moving to true, so it doesn't loop

       isMoving = true;
   
    //while dice is active, move

   while(SecondDice> 0) 
    {



         routePosition++;
         routePosition %= FindObjectOfType<Route>().nodeElements.Count;

         //Net step is now equal to the node +1 node

         Vector3 nextPos = FindObjectOfType<Route>().nodeElements[routePosition].position;

         //While the player is moving towards node, dont keep adding positions

         while(MoveToNextNode1(nextPos))
         {
             yield return null;
       
         }

         //delay each movement by 0.1 frame

        yield return new WaitForSeconds(0.1f);

        //-1 from dice to eventually reach 0

        SecondDice--;

    }



    while(FirstDice> 0) 
    {

        //Same code as above (SecondDice While loop)

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

    //Find the Final position of player after the while loops for dice

    //Print it so You know its working

FinalPos = FindObjectOfType<Route>().nodeElements[routePosition].position;
//Debug.Log(FinalPos);

    //Make a PhotonView and set it to current view
    //Call RPC SendPosition for all clients except the user, using param FinalPos
    
PhotonView pView = GetComponent<PhotonView>();
pView.RPC("SendPosition", RpcTarget.OthersBuffered, FinalPos);


    //Once done, call endState
        EndState();
}

public void EndState()
{
    //Set move values to false so next roll active state is reset
        isMoving = false; 
        moveAllowed = false;
}



[PunRPC]
 public void SendPosition(Vector3 a)
   {
       //Variable a which is FinalPos transforms playerGameObject 
       //This is done for other client so they know where the other client is
       player2 = GameObject.Find("Player2(Clone)");
       player2.transform.position = a;
   }

// The thing that MOVES EACH NODE, Return this VECTOR3 VALUE

[PunRPC]
bool MoveToNextNode1(Vector3 MoveIt) 
{

    //Move PLAYER from the TRANSFORMED.POSITION to GOAL 
    
    //At a time of 4fractional seconds times the Time.deltatime

    return MoveIt != (transform.position = Vector3.MoveTowards(transform.position, MoveIt, 4f * Time.deltaTime));

}

}
