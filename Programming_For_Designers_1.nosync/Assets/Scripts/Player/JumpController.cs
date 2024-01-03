using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using FMODUnity;
using FMOD.Studio;

public class JumpController : MonoBehaviour
{

    Rigidbody2D rb;

    public InputActionAsset playerControls;
    public InputAction jump;

    public float jumpForce = 1.0f;

    [SerializeField] GroundController ground;

    public EventReference jumpSound;


    private void Awake()
    {
        jump = playerControls.FindAction("jump");
        jump.performed += _ => Jump();
    }

    private void OnEnable()
    {
        jump.Enable();
    }

    private void OnDisable()
    {
        jump.Disable();
    }

    private void Jump()
    {
        if (ground.IsGrounded()) // Add parentheses here
        {
            rb.AddForce(new Vector2(0, jumpForce), ForceMode2D.Impulse);
            RuntimeManager.PlayOneShot(jumpSound, transform.position);
            Debug.Log("Jump sound should play"); // Add this line
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (jump.WasPressedThisFrame())
        {
            Jump();
        }
    }
}
