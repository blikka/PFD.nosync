using System.Collections;
using System.Collections.Generic;
using FMODUnity;
using UnityEngine;
using FMOD.Studio;

public class GroundController : MonoBehaviour
{
    [SerializeField] private bool grounded;
    private bool wasInAir = false;
    public EventReference landSound;
    public bool IsGrounded()
    {
        return grounded;
    }

    // Start is called before the first frame update
    void Start()
    {
        grounded = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (grounded && wasInAir)
        {
            // The player was in the air in the last frame and is now grounded, so they have just landed
            RuntimeManager.PlayOneShot(landSound, transform.position); // Play the landing sound
            wasInAir = false; // Reset the flag
        }
        else if (!grounded)
        {
            // The player is not grounded, so they are in the air
            wasInAir = true;
        }
    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        grounded = true;
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        grounded = false;
    }
}
