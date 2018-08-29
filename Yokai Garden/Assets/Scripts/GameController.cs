using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public static GameController instance;         //A reference to our game control script so we can access it statically.
    public Text starScoreText;                      //A reference to the UI text component that displays the player's score.
    public GameObject gameOvertext;             //A reference to the object that displays the text which appears when the player dies.
    public bool waitForClick = false;

    public static int starsCollected = 0;             //The stars collected
    public bool gameOver = false;               //Is the game over?
    public float scrollSpeed = -1.5f;


    void Awake()
    {
        //If we don't currently have a game control...
        if (instance == null)
            //...set this one to be it...
            instance = this;
        //...otherwise...
        else if (instance != this)
            //...destroy this one because it is a duplicate.
            Destroy(gameObject);
    }

    void Update()
    {
        //If the game is over and the player has pressed some input...
        if (gameOver && Input.GetMouseButtonDown(0))
        {
            //...reload the current scene.
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }

    public void starCount()
    {
        //Can't shoot no stars if the game is over, sucker!
        if (gameOver)
            return;

        if (waitForClick == false)
        {
            waitForClick = true;
            StartCoroutine(StarsCoroutine());
        }        
    }

    IEnumerator StarsCoroutine()
    {
        yield return new WaitForSeconds(0.1f);

        starsCollected++;
        starScoreText.text = starsCollected.ToString();
        
        waitForClick = false;
    }

    public void GameOver()
    {
        //Activate the game over text.
        gameOvertext.SetActive(true);
        //Set the game to be over.
        gameOver = true;
    }
}