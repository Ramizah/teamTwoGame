using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

// Created by Caleb

//This file is the alternate one to player2Mini, works better with camera and multiplayer functionality

//Checks if the Photon view is the players then creates rigid body and colliders for the player so they can platform.

//Gives player velocity and resets jump when they hit the ground

public class Player1Mini : MonoBehaviour
{
    [SerializeField]private float speed;
    private Rigidbody2D Player;

    public Transform JumpCheck;
    public float JumpCheckRadius;
    public LayerMask JumpLayer;
    public bool IsTouchingGround;
    PhotonView View;

    void Start()
    {
        View = GetComponent<PhotonView>();
    }

    void Awake()
    {
        Player = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if(View.IsMine)
        {
            IsTouchingGround = Physics2D.OverlapCircle(JumpCheck.position, JumpCheckRadius, JumpLayer);

            Player.velocity = new Vector2(Input.GetAxis("Horizontal") * speed, Player.velocity.y);

            if(Input.GetKey(KeyCode.UpArrow) && IsTouchingGround == true)
            {
                Player.velocity = new Vector2(Player.velocity.x, speed * 0.75f);
            }
        }
    }
}

