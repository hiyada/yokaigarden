using UnityEngine;
using System.Collections;

public class Star : MonoBehaviour
{
    public float xForce;                    //this is the sideways force the star will travel
    public float yForce;                    //this is the downward force the star will travel

    public AudioSource starSFX;

    private Rigidbody2D starObject;         //holds a reference to the RigidBody2D component of the star object

    static bool _hasAssignedOfficialAudioSource;

    private void Start()
    {
        starObject = GetComponent<Rigidbody2D>();
        starSFX = GetComponent<AudioSource>();
        if (_hasAssignedOfficialAudioSource == false)
        {
            _hasAssignedOfficialAudioSource = true;
        }
        else
        {
            this.starSFX.enabled = false;
        }
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            starObject.AddForce(new Vector2(xForce, yForce));
            starObject.GetComponent<Rigidbody2D>().velocity = Vector2.zero;
            starSFX.pitch = Random.Range(.95f, 1.05f);
            starSFX.volume = Random.Range(.9f, 1f);
            if (starSFX.isActiveAndEnabled)
                starSFX.Play();

            GameController.instance.starCount();
        }
    }
}