using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueEnd : MonoBehaviour {

    Text text1;
    public float timer;

	// Use this for initialization
	void Start () {
        text1 = GetComponent<Text>();
        text1.enabled = true;
	}
	
	// Update is called once per frame
	void Update () {
        timer -= Time.deltaTime;

        if (timer <= 0.0f)
        {
            text1.enabled = false;
            this.enabled = false;
        }
	}
}
