using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YokaiProgress : MonoBehaviour {

    public float progress = 0;
    public Vector2 position = new Vector2(6f, 220.4f);
    public Vector2 size = new Vector2(578.6f, 57.83f);
    public Texture2D progress_empty_Image;
    public Texture2D progress_full_Image;
    public float run = 0.01f;
    public float speed = 0;
    bool check = false;

    private void OnGUI()
    {
        GUI.DrawTexture(new Rect(position.x, position.y, size.x, size.y), progress_empty_Image);
        GUI.DrawTexture(new Rect(position.x, position.y, size.x*Mathf.Clamp01(progress), size.y), progress_full_Image);
    }

    private void Update()
    {
        if (check == false)
        {
            StartCoroutine(delay());
        }
    }

    IEnumerator delay ()
    {
        check = true;
        progress = progress + run;
        yield return new WaitForSeconds(speed);
        check = false;
    }
}
