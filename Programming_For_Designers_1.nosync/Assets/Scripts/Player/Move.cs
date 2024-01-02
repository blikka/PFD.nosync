using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Move : MonoBehaviour
{

    public Transform taterTransform;

    public float speed = 1.0f;

    public InputActionAsset playerControls;
    public InputAction move;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void Awake()
    {
           move = playerControls.FindAction("move");
    }

    private void OnEnable()
    {
        move.Enable();
    }

    private void OnDisable()
    {
        move.Disable();
    }

    // Update is called once per frame
    void Update()
    {
    Vector3 pos = transform.position;
    var distance = speed * Time.deltaTime;
    var direction = move.ReadValue<float>();
    pos.x += direction * distance;
    transform.position = pos;
    }
}
