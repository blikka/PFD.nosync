using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAheadController : MonoBehaviour
{

    public GameObject target;
    public float speed = 5;





    // Start is called before the first frame update
    void Start()
    {
        if (target == null)
        {
            this.enabled = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        var view = Camera.main.WorldToViewportPoint(target.transform.position);
        var movement = speed * Time.deltaTime;
        var position = transform.position;
            
            if (view.x > 0.75)
            {
                position.x += movement;
            }
            if (view.x < 0.25)
            {
                position.x -= movement;
            }
            
            if (view.y > 0.75)
            {
                position.y += movement;
            }

            if (view.y < 0.25)
            {
                position.y -= movement;
            }

        transform.position = position;
        
    }
}
