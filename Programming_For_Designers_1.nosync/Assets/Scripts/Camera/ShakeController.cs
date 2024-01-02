using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShakeController : MonoBehaviour
{

    public float min = 0;
    public float max = 0.5f;

    public Vector3 original;

    private void OnEnable()
    {
        original = transform.position;
    }


    private void OnDisable()
    {
        transform.position = original;
    }
        

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var x = original.x + Random.Range(min, max);
        var y = original.y + Random.Range(min, max);
        transform.position = new Vector3(x, y, original.z);
    }
}
