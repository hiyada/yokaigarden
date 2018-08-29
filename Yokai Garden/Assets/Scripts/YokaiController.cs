using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YokaiController : MonoBehaviour
{
    bool lampchanged = false;
    public GameObject lamp;

	public void LampToggle(bool lampchanged)
    {
        Vector2 lampPos = lamp.transform.position;
        Debug.Log("yes");
        lamp.SetActive(lampchanged);
    }
}
