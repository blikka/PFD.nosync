using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GuardController : MonoBehaviour
{
    public GameObject[] waypoints;
    public GameObject target;
    public int iterator = 0;
    public float speed = 2f;

    // Start is called before the first frame update
    void Start()
    {
        // Set the target to the closest waypoint at the start of the game
        //TargetClosest();
    }

    private void NextWaypoint()
    {
        // Increment the iterator
        iterator++;

        // If the iterator is equal to the length of the waypoints array, reset it to 0
        if (iterator == waypoints.Length)
        {
            iterator = 0;
        }

        // Set the target to the next waypoint
        target = waypoints[iterator];

        // Rotate the guard 180 degrees on the y-axis
        transform.rotation *= Quaternion.Euler(0, 180, 0);

        // Log the new target for debugging
        Debug.Log("New target: " + target.name);
    }

    /*private void TargetClosest()
    {
        GameObject closest = null;
        double shortest = double.MaxValue;
        for (int i = 0; i < waypoints.Length; i++)
        {
            double dist = Vector3.Distance(transform.position, waypoints[i].transform.position);
            if (dist < shortest)
            {
                shortest = dist;
                closest = waypoints[i];
                iterator = i; // Update the iterator to match the index of the closest waypoint
            }
        }
        iterator--; // Decrement the iterator by 1
        if (iterator < 0) // If the iterator is less than 0, set it to the last index
        {
            iterator = waypoints.Length - 1;
        }
        target = closest;
    }*/

    // Update is called once per frame
    void Update()
    {
        // Move the guard towards the target
        float step = speed * Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, target.transform.position, step);

        // If the guard is close enough to the target, move to the next waypoint
        float distanceToTarget = Vector3.Distance(transform.position, target.transform.position);
        if (distanceToTarget < 1f) // Increase the distance threshold
        {
            NextWaypoint();
        }
    }
}
