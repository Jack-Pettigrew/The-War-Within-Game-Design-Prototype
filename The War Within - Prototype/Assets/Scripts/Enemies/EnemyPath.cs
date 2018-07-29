using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPath : MonoBehaviour {

    public Transform[] path; // array holding points
    public float speed = 10f; // speed of enemy movement
    public float arrived = 1.0f; // radius of the point marking arrival
    public int currentPos = 0; // iterator for changing to the next point
    private float timer = 2.5f; // enemy wait timer

    void Start()
    { 

    }

    void FixedUpdate () {

        float dist = Vector3.Distance(path[currentPos].position, transform.position); // New float 'dist' holding the dist between objs

        transform.position = Vector3.MoveTowards(transform.position, path[currentPos].position, Time.deltaTime * speed); // Apply MoveTowards to this objects transform.position
        
        if(dist <= arrived) // Go to next point when 'dist' <= the arrival radius
        {
            if(timer > 0) // if timer is > 0...
            {
                timer -= Time.deltaTime; // reduce it by real time
                return;
            }

            timer = 2.5f; // reset timer afterwards

           currentPos++; // iterate to next point
        }

        if(currentPos >= path.Length) // If currentPos is >= to total array...
        {
            currentPos = 0; // Reset currentPos
        }

        transform.LookAt(path[currentPos]);
    }
}
