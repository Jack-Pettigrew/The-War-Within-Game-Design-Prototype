using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpotted : MonoBehaviour {

    public Transform player, spottedRespawn;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            player.position = spottedRespawn.position;
            player.rotation = spottedRespawn.rotation;
        }
    }
}
