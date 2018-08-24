/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootingStars : MonoBehaviour
{
    
    public GameObject starsPrefab; //the stars game object
    public int starPoolSize = 10; //10 stars
    public float starXMin = 0f;
    public float starXMax = 10f;
    public float starYMin = 0f;
    public float starYMax = 10f;

    private GameObject[] stars;
    private int currentStar = 0;
    private bool gameOver = false;

    private Vector2 starPoolPosition = new Vector2(-15, -25);

	// Use this for initialization
	void Start ()
    {
        stars = new GameObject[starPoolSize];

		for(int i = 0; i < starPoolSize; i++)
        {
            stars[i] = (GameObject)Instantiate(starsPrefab, starPoolPosition, Quaternion.identity);
        }
	}
	
	// Update is called once per frame
	void Update ()
    {
		if (gameOver == false)
        {
            if (Input.GetMouseButtonDown(0))
            {
                float spawnXPosition = Random.Range(starXMin, starXMax);
                float spawnYPosition = Random.Range(starYMin,starYMax);

                stars[currentStar].transform.position = new Vector2(spawnXPosition, spawnYPosition);
                currentStar++;

                if (currentStar >= starPoolSize)
                {
                    currentStar = 0;
                }
            }
        }
	}
}
    
using UnityEngine;
using System.Collections;

public class Bird : MonoBehaviour 
{
    public float upForce;                   //Upward force of the "flap".
    private bool isDead = false;            //Has the player collided with a wall?

    private Animator anim;                  //Reference to the Animator component.
    private Rigidbody2D rb2d;               //Holds a reference to the Rigidbody2D component of the bird.

    void Start()
    {
        //Get reference to the Animator component attached to this GameObject.
        anim = GetComponent<Animator> ();
        //Get and store a reference to the Rigidbody2D attached to this GameObject.
        rb2d = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        //Don't allow control if the bird has died.
        if (isDead == false) 
        {
            //Look for input to trigger a "flap".
            if (Input.GetMouseButtonDown(0)) 
            {
                //...tell the animator about it and then...
                anim.SetTrigger("Flap");
                //...zero out the birds current y velocity before...
                rb2d.velocity = Vector2.zero;
                //  new Vector2(rb2d.velocity.x, 0);
                //..giving the bird some upward force.
                rb2d.AddForce(new Vector2(0, upForce));
            }
        }
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        // Zero out the bird's velocity
        rb2d.velocity = Vector2.zero;
        // If the bird collides with something set it to dead...
        isDead = true;
        //...tell the Animator about it...
        anim.SetTrigger ("Die");
        //...and tell the game control about it.
        GameControl.instance.BirdDied ();
    }
}*/
