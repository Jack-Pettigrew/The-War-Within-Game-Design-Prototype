using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    private Rigidbody rb;

    // movement bools
    public float forceSpeed = 100f;
    // used for rb.position movement
    private Vector3 velocity = Vector3.zero;

    // Use this for initialization
    void Start () {
        rb = GetComponent<Rigidbody>();
	}
	
	// FixedUpdate is called once per frame
	void FixedUpdate () {

        // Controls bools for PlayerMotor
        if (Input.GetKey("w"))
        {
            velocity = new Vector3(-forceSpeed, 0, 0);
            rb.MovePosition(rb.position + velocity * Time.fixedDeltaTime);
        }
        if (Input.GetKey("s"))
        {
            velocity = new Vector3(forceSpeed, 0, 0);
            rb.MovePosition(rb.position + velocity * Time.fixedDeltaTime);
        }
        if (Input.GetKey("a"))
        {
            velocity = new Vector3(0, 0, -forceSpeed);
            rb.MovePosition(rb.position + velocity * Time.fixedDeltaTime);
        }
        if (Input.GetKey("d"))
        {
            velocity = new Vector3(0, 0, forceSpeed);
            rb.MovePosition(rb.position + velocity * Time.fixedDeltaTime);
        }
    }
}
