﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Player : MonoBehaviour
{

    public GameManager gameManager;
    public float speed = 10f;
    private Rigidbody playerRigidbody;
    
    void Start()
    {
        playerRigidbody = GetComponent<Rigidbody>();
    }
    void Update()
    {

        if(gameManager.isGameOver == true)
        {
            return;
        }

        float inputX = Input.GetAxis("Horizontal");
        float inputZ = Input.GetAxis("Vertical");

        float fallSpeed = playerRigidbody.velocity.y;

        Vector3 velocity = new Vector3(inputX, 0, inputZ);

        velocity = velocity * speed;
        velocity.y = fallSpeed;

        playerRigidbody.velocity = velocity;

    }
}
