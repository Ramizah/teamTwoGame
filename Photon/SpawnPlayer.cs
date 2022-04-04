using Photon.Realtime;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using Photon.Pun;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SpawnPlayer : MonoBehaviourPun
{
    public GameObject Player, Player2; //GameObjects to be spawned 
    public GetUserID ID;
    PhotonView myPV; //?? Not really being used right now, but might be useful later
    Player[] allPlayers; // Make an array of all the current Players in Room
    public int myNumberInRoom; //Sets ID of the players in the SPECIFIC room
    public int ConstantID;
    public int P1Choice;
    public int P2Choice;

    public SpriteRenderer SpriteRenderer1;
    public SpriteRenderer SpriteRenderer2;
    
    public Sprite Sprite1;
    public Sprite Sprite2;
    public Sprite Sprite3;
    public Sprite Sprite4;
    public Sprite Sprite5;
    public Sprite Sprite6;

    public void Start() {
        ID = FindObjectOfType<GetUserID>();
        myPV = GetComponent<PhotonView>();

        Debug.Log(CharacterSelect.FinalChoice);

        if(ID.myNumberInRoom == 0)
        {
            ConstantID = 0;

            if(CharacterSelect.FinalChoice == 1)
            {
            SpriteRenderer1.sprite = Sprite1;
            }
            if(CharacterSelect.FinalChoice == 2)
            {
            SpriteRenderer1.sprite = Sprite2;
            }
            if(CharacterSelect.FinalChoice == 3)
            {
            SpriteRenderer1.sprite = Sprite3;
            }
            if(CharacterSelect.FinalChoice == 4)
            {
            SpriteRenderer1.sprite = Sprite4;
            }
            if(CharacterSelect.FinalChoice == 5)
            {
            SpriteRenderer1.sprite = Sprite5;
            }
            if(CharacterSelect.FinalChoice == 6)
            {
            SpriteRenderer1.sprite = Sprite6;
            }

            P1Choice = CharacterSelect.FinalChoice;
            myPV.RPC("ChangeForP2", RpcTarget.OthersBuffered, P1Choice);
        }

        if(ID.myNumberInRoom == 1)
        {
            ConstantID = 1;

            if(CharacterSelect.FinalChoice == 1)
            {
            SpriteRenderer2.sprite = Sprite1;
            }
            if(CharacterSelect.FinalChoice == 2)
            {
            SpriteRenderer2.sprite = Sprite2;
            }
            if(CharacterSelect.FinalChoice == 3)
            {
            SpriteRenderer2.sprite = Sprite3;
            }
            if(CharacterSelect.FinalChoice == 4)
            {
            SpriteRenderer2.sprite = Sprite4;
            }
            if(CharacterSelect.FinalChoice == 5)
            {
            SpriteRenderer2.sprite = Sprite5;
            }
            if(CharacterSelect.FinalChoice == 6)
            {
            SpriteRenderer2.sprite = Sprite6;
            }

            P2Choice = CharacterSelect.FinalChoice;
            myPV.RPC("ChangeForP1", RpcTarget.OthersBuffered, P2Choice);
        }

        Instantiate();

    }

    public void Instantiate()
    {

        if(ConstantID == 0)
        {
            Debug.Log("You Are Player 1");
            Vector3 Position1 = new Vector3(5,-4,-1);
            PhotonNetwork.Instantiate(Player.name, Position1, Quaternion.identity);
        }
        if(ConstantID == 1)
        {
            Debug.Log("You Are Player 2");
            Vector3 Position1 = new Vector3(5,-4,-1);
            PhotonNetwork.Instantiate(Player2.name, Position1, Quaternion.identity);
        }
        else if(ConstantID != 0 && ConstantID != 1)
        {
            LeaveRoom();
        }
    }

    [PunRPC]
    public void ChangeForP2(int SkinP1)
    {
        Debug.Log(SkinP1);
        if(SkinP1 == 1)
        {
        SpriteRenderer1.sprite = Sprite1;
        }
        if(SkinP1 == 2)
        {
        SpriteRenderer1.sprite = Sprite2;
        }
        if(SkinP1 == 3)
        {
        SpriteRenderer1.sprite = Sprite3;
        }
        if(SkinP1 == 4)
        {
        SpriteRenderer1.sprite = Sprite4;
        }
        if(SkinP1 == 5)
        {
        SpriteRenderer1.sprite = Sprite5;
        }
        if(SkinP1 == 6)
        {
        SpriteRenderer1.sprite = Sprite6;
        }
    }

    [PunRPC]
    public void ChangeForP1(int SkinP2)
    {
        if(SkinP2 == 1)
        {
        SpriteRenderer2.sprite = Sprite1;
        }
        if(SkinP2 == 2)
        {
        SpriteRenderer2.sprite = Sprite2;
        }
        if(SkinP2 == 3)
        {
        SpriteRenderer2.sprite = Sprite3;
        }
        if(SkinP2 == 4)
        {
        SpriteRenderer2.sprite = Sprite4;
        }
        if(SkinP2 == 5)
        {
        SpriteRenderer2.sprite = Sprite5;
        }
        if(SkinP2 == 6)
        {
        SpriteRenderer2.sprite = Sprite6;
        }
    }






        public void LeaveRoom()
        {
            StartCoroutine(LeavingRoom());
        }

        public IEnumerator LeavingRoom()
        {
            PhotonNetwork.LeaveRoom();
            while(PhotonNetwork.InRoom)
            {
                yield return null;
            }
            PhotonNetwork.LoadLevel("ReJoin");
        }


}       
