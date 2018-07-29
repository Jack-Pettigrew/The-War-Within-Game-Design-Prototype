using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpotlightTransform : MonoBehaviour {

    public Transform[] spotlightPoints;
    public float timer, speed;
    float reset;
    int i;

	// Use this for initialization
	void Start () {
        reset = timer;
        i = 0;
	}
	
	// Update is called once per frame
	void Update () {

        if (i >= spotlightPoints.Length)
            i = 0;

        this.transform.position = Vector3.MoveTowards(this.transform.position, spotlightPoints[i].transform.position, speed * Time.deltaTime);

        if (this.transform.position.x == spotlightPoints[i].transform.position.x)
        {
            timer -= Time.deltaTime;

            if (timer <= 0f)
            {
                timer = reset;
                i++;
            }
        }
	}
}
