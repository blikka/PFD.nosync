using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementController : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Movement for player

        Vector3 pos = transform.position;
        float distance = 5 * Time.deltaTime;

        if (Input.GetKey(KeyCode.D))
        {
            pos.x += distance;
        }

        if (Input.GetKey(KeyCode.A))
        {
            pos.x -= distance;
        }

        if (Input.GetKey(KeyCode.S))
        {
            pos.y -= distance;
        }

        if (Input.GetKey(KeyCode.W))
        {
            pos.y += distance;
        }

        transform.position = pos;
    }
}
