using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{

    // Enemy Target

    public GameObject target;

    // Start is called before the first frame update

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        // Enemy Movement

        Vector3 dest = target.transform.position;
        Vector3 pos = transform.position;
        float distance = 2 * Time.deltaTime;

        if (pos.x > dest.x)
        {
            pos.x -= distance;
        }

        else
        {
            pos.x += distance;
        }

            pos.y = transform.position.y;

        transform.position = pos;

    }
}