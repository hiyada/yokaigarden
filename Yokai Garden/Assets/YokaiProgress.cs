using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YokaiProgress : MonoBehaviour
{
    const float ArrivalTimeForProgressBar = 1f;
    public float progress = 0, progress_velocity;
    public Vector2 position = new Vector2(6f, 220.4f);
    public Vector2 size = new Vector2(578.6f, 57.83f);
    public Texture2D progress_empty_Image;
    public Texture2D progress_full_Image;
    public float run = 0.01f;
    public float speed = 0;
    //bool check = false;
    public GameObject lampYokai;

    const int ButtonAmount = 6;
    int buttonsPressed = 0;

    float buttonsPressedRatio01
    {
        get
        {
            return Mathf.Clamp01(((float)buttonsPressed) / ((float)ButtonAmount));
        }
    }

    public bool HasPlayerWon
    {
        get
        {
            return this.progress >= 0.98f;  //mathf.approximately
        }
    }

    public void IncrementProgressBar()
    {
        buttonsPressed++;
        Debug.Log(buttonsPressedRatio01); 
    }

    private void OnGUI()
    {
        GUI.DrawTexture(new Rect(position.x, position.y, size.x, size.y), progress_empty_Image);
        GUI.DrawTexture(new Rect(position.x, position.y, size.x * Mathf.Clamp01(progress), size.y), progress_full_Image);
    }

    private void Update()
    {
        this.progress = Mathf.SmoothDamp(this.progress, this.buttonsPressedRatio01, ref this.progress_velocity, ArrivalTimeForProgressBar);
        //if (check == false)
        //{
        //    StartCoroutine(checkProgress());
        //}
    }

    //IEnumerator checkProgress()
    //{
    //    /*if (lampYokai.activeSelf == true)
    //    {
    //        Debug.Log("test complete");
    //        progress = progress + run;
    //        check = false;
    //        yield return;
    //    }*/

    //    check = true;
    //    progress = progress + run;
    //    yield return new WaitForSeconds(speed);
    //    check = false;
    //}
}
