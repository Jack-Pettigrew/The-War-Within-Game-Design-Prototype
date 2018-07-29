using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupRotation : MonoBehaviour {

    public float rotationSpeed = 10f;
    public AudioSource collect;
    public GameObject goal;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        transform.Rotate(rotationSpeed * Time.fixedDeltaTime, rotationSpeed * Time.fixedDeltaTime, 0);
	}

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            goal.SetActive(true);
            gameObject.SetActive(false);
            collect.Play();
        }
    }
}
