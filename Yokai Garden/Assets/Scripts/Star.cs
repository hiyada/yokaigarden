using UnityEngine;
using System.Collections;

public class Star : MonoBehaviour
{
    public float yForce;                    //this is the downward force the star will travel

    private Rigidbody2D starObject;         //holds a reference to the RigidBody2D component of the star object

    private void Start()
    {
        starObject = GetComponent<Rigidbody2D>();
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (Input.GetMouseButtonDown(0))
        {
            starObject.velocity = Vector2.zero;
            starObject.AddForce(new Vector2(0, yForce));
            //If the bird hits the trigger collider in between the columns then
            //tell the game control that the bird scored.
            GameController.instance.starCount();
        }
    }
}