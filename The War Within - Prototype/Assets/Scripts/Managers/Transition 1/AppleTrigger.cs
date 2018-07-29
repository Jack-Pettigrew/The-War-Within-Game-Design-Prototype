using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppleTrigger : MonoBehaviour {

    public Rigidbody apple;
    public float force;

    void OnTriggerEnter(Collider other)
    {
        apple.AddForce(Vector3.forward * force);
    }
}
