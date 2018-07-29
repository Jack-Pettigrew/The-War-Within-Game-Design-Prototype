using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GoalScript : MonoBehaviour {

    public RawImage overlay;
    public Animator animate;

	// Use this for initialization
	void Start () {
        animate.enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            animate.enabled = true;
        }
    }
}
