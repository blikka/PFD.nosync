using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundController : MonoBehaviour
{
    [SerializeField] private bool grounded;
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
