using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyLookAt : MonoBehaviour {

    public Transform[] lookAtPoints;
    public int timerStart;
    public float speed;

    float timer;
    int i = 0;

	// Use this for initialization
	void Start () {
        timer = timerStart;
        transform.LookAt(lookAtPoints[i]);
	}
	
	// Update is called once per frame
	void Update () {

        timer -= Time.deltaTime;

        if(timer <= 0)
        {
            i++;
            timer = timerStart;
        }

        if(i >= lookAtPoints.Length)
        {
            i = 0;
        }

        // Following code referenced from...
        Vector3 direction = lookAtPoints[i].position - this.transform.position;                         // Create Vector3 of the next lookAtPoint
        Quaternion rotation = Quaternion.LookRotation(direction);                                       // Create rotation Quaternion holding the rotation to the direction of object
        transform.rotation = Quaternion.Lerp(transform.rotation, rotation, speed * Time.deltaTime);     // Apply gradually
        //... https://www.youtube.com/watch?v=nJiFitClnKo

    }
}
