using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Created by Caleb

public class Route : MonoBehaviour {


     //--------------------------------------------------------ALL CODE NEEDS TO CONNECT TO MULTIPLAYER DATABASE---------------------------------------------------//



    //Create Transform property (used to store manipulate position os GameObject) name nodeGameObjects - node unity object

    //Create new List Transform for all nodes to be stored

Transform[] nodeGameObjects;
public List<Transform> nodeElements = new List<Transform>();

  
    //-----------------------------------------------------------------------------CREATE LINES---------------------------------------------------------//

    //To make nodes clear when in Scene tab  on Unity. Draw lines between Nodes
    //Can remove these once game is done

    void OnDrawGizmos()
    {
        //LINE COLOUR GREEN

        Gizmos.color = Color.red;
        //CALL FILL NODE

        FillNodes();

        //For each potential node posiiton. create vector3 CurrentPos

        for (int i = 0; i < nodeElements.Count; i++)
        {
            Vector3 currentposition = nodeElements[i].position;

            //If INT i is bigger than - (nodes locations still need to be found)
            //create PreviousPostition, -1 to reduce list and draw line between new and old position

            if(i > 0)
            {
                Vector3 PreviousPostition = nodeElements[i - 1].position;

                Gizmos.DrawLine(PreviousPostition, currentposition);
            }
        }
    }

    //-------------------------------------------------------------------------FILL CREATED LIST WITH NODES--------------------------------------------------------------------//

    void FillNodes()
    {
        //Make sure default list size is empty

        nodeElements.Clear();

        //Define nodeGameObjects as positions to be filled with nodes

        nodeGameObjects = GetComponentsInChildren<Transform>();

        //Fill each Node

        foreach(Transform child in nodeGameObjects)
        {
          if(child != this.transform) 
          {
              nodeElements.Add(child);
          }  
           
        }
    }

}
