﻿using UnityEngine;
using System.Collections;

public class Star : MonoBehaviour
{
    public float xForce;                    //this is the sideways force the star will travel
    public float yForce;                    //this is the downward force the star will travel

    private Rigidbody2D starObject;         //holds a reference to the RigidBody2D component of the star object

    private void Start()
    {
        starObject = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            //this shoots the star
            starObject.AddForce(new Vector2(xForce, yForce));
            //Increase the amount of stars collected if the screen is clicked.  
            GameController.instance.starCount();

            starObject.GetComponent<Rigidbody2D>().velocity = Vector2.zero;
        }
    }
}