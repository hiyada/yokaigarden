using System.Collections;
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

    private Vector2 starPoolPosition = new Vector2(-15f, -25f);

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