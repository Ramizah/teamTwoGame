using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Created by Caleb

public class Player2Mini : MonoBehaviour
{
    [SerializeField]private float speed;
    private Rigidbody2D Player2;
    public SpawnPlayer ID;

    public Transform JumpCheck;
    public float JumpCheckRadius;
    public LayerMask JumpLayer;
    public bool IsTouchingGround;

    //Abandoned file, test for player movement across network using the ID

    void Start()
    {
        ID = FindObjectOfType<SpawnPlayer>();
    }


    void Awake()
    {
        Player2 = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if(ID.ConstantID == 1)
        {
            IsTouchingGround = Physics2D.OverlapCircle(JumpCheck.position, JumpCheckRadius, JumpLayer);

            Player2.velocity = new Vector2(Input.GetAxis("Horizontal") * speed, Player2.velocity.y);

            if(Input.GetKey(KeyCode.UpArrow) && IsTouchingGround == true)
            {
                Player2.velocity = new Vector2(Player2.velocity.x, speed * 0.75f);
            }

        }
    }
}
