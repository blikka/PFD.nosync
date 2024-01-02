using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class JumpController : MonoBehaviour
{

    Rigidbody2D rb;

    public InputActionAsset playerControls;
    public InputAction jump;

    public float jumpForce = 1.0f;

    [SerializeField] GroundController ground;

    private void Awake()
    {
        jump = playerControls.FindAction("jump");
    }

    private void OnEnable()
    {
        jump.Enable();
    }

    private void OnDisable()
    {
        jump.Disable();
    }

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
        if (jump.WasPressedThisFrame() && ground.IsGrounded())
        {
            rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
        }

    }
}
