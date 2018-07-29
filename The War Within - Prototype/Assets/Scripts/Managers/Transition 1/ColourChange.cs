using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColourChange : MonoBehaviour {

    public Transform player;
    public Transform table;
    Light lights;
    float distance;

	// Use this for initialization
	void Start () {
        lights = GetComponent<Light>();
	}
	
	// Update is called once per frame
	void Update () {
        distance = player.transform.position.z - table.transform.position.z;

        lights.color = Color.Lerp(Color.white, Color.red, distance);
	}
}
