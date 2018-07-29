using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class EnvolopeGoal : MonoBehaviour {

    public Transform envolope;
    public AudioSource Ambience, Click;
    public Canvas canvas;
    public string levelChange;

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
            envolope.gameObject.SetActive(false);
            Ambience.Stop();
            canvas.gameObject.SetActive(true);
            Click.Play();
            Invoke("ChangeLevel", 2.0f);
        }
    }

    void ChangeLevel()
    {
        SceneManager.LoadScene(levelChange);
    }
}