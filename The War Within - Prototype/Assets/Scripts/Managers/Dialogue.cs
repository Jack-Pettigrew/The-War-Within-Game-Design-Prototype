using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Dialogue : MonoBehaviour {

	public Text one;
	public string loadLevel;
	public float interval; 

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "Player") 
		{
			First ();
			Invoke("LoadLevel", interval);
		}
	}

	void First()
	{
		one.enabled = true;
	}

	void LoadLevel()
	{
		if (loadLevel == null)
			return;
		else
			SceneManager.LoadScene (loadLevel);
	}
}
