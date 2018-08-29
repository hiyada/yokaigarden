using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class YokaiController : MonoBehaviour
{
    public Toggle lampToggle;
    public Toggle wishToggle;
    public Toggle taikoToggle;
    public Toggle nekoToggle;
    public Toggle foodStandToggle;
    public Toggle dragonFloatToggle;

    void Update() 
    {
        if (GameController.starsCollected >= 10 && !lampToggle.interactable)
        {
            lampToggle.interactable = !lampToggle.interactable;
        }
        if (GameController.starsCollected >= 20 && !wishToggle.interactable)
        {
            wishToggle.interactable = !wishToggle.interactable;
        }
        if (GameController.starsCollected >= 30 && !taikoToggle.interactable)
        {
            taikoToggle.interactable = !taikoToggle.interactable;
        }
        if (GameController.starsCollected >= 40 && !nekoToggle.interactable)
        {
            nekoToggle.interactable = !nekoToggle.interactable;
        }
        if (GameController.starsCollected >= 50 && !foodStandToggle.interactable)
        {
            foodStandToggle.interactable = !foodStandToggle.interactable;
        }
        if (GameController.starsCollected >= 60 && !dragonFloatToggle.interactable)
        {
            dragonFloatToggle.interactable = !dragonFloatToggle.interactable;
        }
    }
}
